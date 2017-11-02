﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




namespace proyectoBD
{
    public class datosUser
    {
        public static List<person> contacs = new List<person>();
        public static List<user> users = new List<user>();

        public List<person> backup1 = new List<person>();
        public List<user> backup2 = new List<user>();

        public datosUser(){
            
        }

        public void addContacts(person p)
        {
            contacs.Add(p);
        }

        public List<person> getContacts()
        {
            return contacs;
        }

        public void removeContacts(int i)
        {
            contacs.RemoveAt(i);
        }

        //------------------------------

        public void addUser(user u)
        {
            users.Add(u);
        }

        public List<user> getUsers()
        {
            return users;
        }

        public void removeUser(int i)
        {
            users.RemoveAt(i);
        }

        public void saveBackup()
        {
            backup1 = contacs;
            backup2 = users;
        }

        public void loadBackup()
        {
            contacs = backup1;
            users = backup2;
        }
    }
}
