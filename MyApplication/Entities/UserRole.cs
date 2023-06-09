﻿namespace MyApplication.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<User> Users { get; set; } = new List<User>();
    }
}
