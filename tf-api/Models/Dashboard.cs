﻿namespace tf_api.Models
{
    public class Dashboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BudgetList> BudgetLists { get; set; }
        public List<TodoList> TodoLists { get; set; }
        public List<Notepad> Notepads { get; set; }
    }
}
