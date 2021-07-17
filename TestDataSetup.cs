using System;
using Xunit;
using SukantAvalara.Api.Domain;
using SukantAvalara.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace SukantAvalara.Api.Tests
{
    public class TestDataSetup : IDisposable
    {
        public SukantAvalaraDataContext Context {get;set;}
        
        public TestDataSetup()
        {
            var builder = new DbContextOptionsBuilder<SukantAvalaraDataContext>()
                        .UseInMemoryDatabase(databaseName: "TestDb")
                        .Options;
            Context = new SukantAvalaraDataContext(builder);

            var list1Guid = Guid.NewGuid();
            Context.TaskList.Add(new TaskList(){
                Id = list1Guid,
                Name = "List1",
                CreateDate = DateTime.Now
            });
            
            var list2Guid = Guid.NewGuid();
            Context.TaskList.Add(new TaskList(){
                Id = list2Guid,
                Name = "List2",
                CreateDate = DateTime.Now
            });

            Context.ToDoTaskDb.Add(new ToDoTaskDb()
            {
                Id = 1,
                ToDoListId = list1Guid.ToString(),
                Description = "Sample Description",
                Subject = "Test",
                CreateDate = DateTime.Now,
                Status = TaskStatus.NotStarted.ToString()
            });

            Context.ToDoTaskDb.Add(new ToDoTaskDb()
            {
                Id = 2,
                ToDoListId = list2Guid.ToString(),
                Description = "Sample Description",
                Subject = "Test",
                CreateDate = DateTime.Now,
                Status = TaskStatus.NotStarted.ToString()
            });

            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}