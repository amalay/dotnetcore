using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amalay.SolidPrinciple.I1
{
    public interface ITask
    {  
        void CreateTask();  

        void AssignTask();  

        void Development();
    }

    public class TeamLead : ITask
    {
        public void CreateTask()
        {
            //Code to create a task            
        }

        public void AssignTask()
        {
            //Code to assign a task.  
        }        

        public void Development()
        {
            //Code to work on assigned task.  
        }
    }

    public class Manager : ITask
    {
        public void CreateTask()
        {
            //Code to create a task
        }

        public void AssignTask()
        {
            //Code to assign a task.  
        }

        public void Development()
        {
            var msg = "Manager can't develop!";
            throw new Exception(msg);
        }
    }
}
