using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.I2
{
    public interface ITask
    {
        void CreateTask();

        void AssignTask();
    }

    public interface IDevelopment
    {
        void Development();
    }

    public class Developer : IDevelopment
    {
        public void Development()
        {
            //Code to work on assigned task. 
        }
    }

    public class Manager : ITask
    {
        public void CreateTask()
        {
            //Code to create a task.  
        }

        public void AssignTask()
        {
            //Code to assign a Task  
        }        
    }

    public class TeamLead : IDevelopment, ITask
    {
        public void CreateTask()
        {
            //Code to create a task.  
        }

        public void AssignTask()
        {
            //Code to assign a Task  
        }

        public void Development()
        {
            //Code to work on assigned task. 
        }
    }
}
