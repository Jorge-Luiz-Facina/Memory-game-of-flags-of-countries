using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Game_Memory.DataBase
{
    public class UserController
    {
        public void save(User user)
        {
            BinaryFormatter bynaryFormater = new BinaryFormatter();
            List<User> users = DeleteOldUser(user);
            users.Add(user);
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + @"/user.bin", FileMode.OpenOrCreate);
            bynaryFormater.Serialize(fileStream, users);
            fileStream.Close();
        }

        public List<User> deserializa()
        {
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + @"/user.bin", FileMode.Open);
            BinaryFormatter bynaryFormater = new BinaryFormatter();
            List<User> users = (List<User>)bynaryFormater.Deserialize(fileStream);
            fileStream.Close();
            return users;
        }

        public User newUser(User newUser)
        {
            List<User> users = deserializa();
            foreach (User user in users)
            {
                if (user.name.Equals(newUser.name))
                    return user;
            }
            return newUser;
        }

        public void deleteAll()
        {
            BinaryFormatter bynaryFormater = new BinaryFormatter();
            List<User> users = new List<User>();
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + @"/user.bin", FileMode.OpenOrCreate);
            bynaryFormater.Serialize(fileStream, users);
            fileStream.Close();
        }

        private List<User> DeleteOldUser(User newUser)
        {
            List<User> users = deserializa();
            foreach (User user in users)
            {
                if (user.name.Equals(newUser.name))
                {
                    users.Remove(user);
                    return users;
                }   
            }
            return users;
        }
    }
}
