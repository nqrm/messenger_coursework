﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Server
{
    [Serializable]
    public class message
    {
        public string username { get; set; }
        public string text { get; set; }
        public DateTime timestamp { get; set; }
        public message()
        {
            this.username = "";
            this.text = "Server is running...";
            this.timestamp = DateTime.UtcNow;
        }
        public message(string username, string text)
        {
            this.username = username;
            this.text = text;
            this.timestamp = DateTime.UtcNow;
        }
    }

    [Serializable]
    public class MessagesClass
    {
        public List<message> messages = new List<message>();
        public void Add(message ms)
        {
            ms.timestamp = DateTime.UtcNow;
            messages.Add(ms);
            Console.WriteLine(messages.Count);
        }
        public message Get(int id)
        {
            return messages.ElementAt(id);
        }
        public int GetCountMessages()
        {
            return messages.Count;
        }
        public MessagesClass()
        {
            messages.Clear();
            message ms = new message();
            messages.Add(ms);
        }
    }
    public class tokens
    {
        public int token { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public tokens()
        {
            this.token = -1;
            this.login = "none";
            this.password = "none";
        }
        public tokens(int token, string login, string password)
        {
            this.token = token;
            this.login = login;
            this.password = password;
        }
    }
    public class SessionsClass
    {
        public List<tokens> list_tokens = new List<tokens>();

        public int GenToken()
        {
            Random rand = new Random();
            return rand.Next(10 * 1000, 100 * 1000);
        }

        public int login(AuthData auth_data)
        {
            string login = auth_data.login;
            string password = auth_data.password;
            bool login_exist = false;
            foreach (tokens item in list_tokens)
            {

                if (item.login == login)
                {
                    login_exist = true;
                    if (item.password == password)
                    {
                        int token = item.token;
                        Console.WriteLine($"Аутентификация успешна login: {login} password: {password} token: {token}");
                        return token;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            if (!login_exist)
            {
                return -2;
            }
            return -200;
        }

        public int registration(AuthData auth_data)
        {
            bool login_exist = false;
            foreach (tokens item in list_tokens)
            {
                if (item.login == auth_data.login)
                {
                    login_exist = true;
                }
            }
            if (!login_exist)
            {
                int token = GenToken();
                tokens record_token = new tokens(token, auth_data.login, auth_data.password);
                list_tokens.Add(record_token);
                Console.WriteLine($"Регистрация успешна login: {auth_data.login} password: {auth_data.password} token: {token}");
                return token;
            }
            return -1;
        }

        public void SaveToFile(string filename = "sessions_data.json")
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            try
            {
                string Data = JsonConvert.SerializeObject(Program.Sessions);
                Console.WriteLine(Data);
                using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Data);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFromFile(string filename = "sessions_data.json")
        {
            long size = 0;
            if (File.Exists(filename))
            {
                FileInfo file = new FileInfo(filename);
                size = file.Length;
            }
            if (size > 0)
            {
                try
                {
                    string json = "";
                    using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
                    {
                        json = sr.ReadToEnd();
                    }
                    Program.Sessions = JsonConvert.DeserializeObject<SessionsClass>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    public class AuthData
    {
        public string login { get; set; }
        public string password { get; set; }
    }
}
