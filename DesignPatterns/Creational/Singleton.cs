﻿namespace ConsoleProject.Creational
{
    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        private Singleton()
        {
            
        }
    }
}
