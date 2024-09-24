﻿using Microsoft.EntityFrameworkCore;
using tf_api.Models;

namespace tf_api.DBContexts
{
    public class TaskFlowDBContext : DbContext
    {
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<BudgetList> BudgetLists { get; set; }
        public DbSet<BudgetItem> BudgetItems { get; set; }

        //public TaskFlowDBContext(DbContextOptions<TaskFlowDBContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TaskFlow;Trust Server Certificate=True;Integrated Security = True");
        }
    }
}
