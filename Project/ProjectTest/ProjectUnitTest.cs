using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Business.Services;
using System;

namespace ProjectUnitTest
{
    [TestClass]
    public abstract class ProjectUnitTest
    {
        protected Object testInstance;

        protected abstract void Init();
    }

    public class EmployeeUnitTest: ProjectUnitTest
    {
        protected override void Init()
        {
            this.testInstance = new EmployeeService();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmployeeNameTestException()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmployeeEmailTestException()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmployeePhoneTestException()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmployeeException1()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EmployeeException2()
        {
        }
    }

    public class TaskUnitTest: ProjectUnitTest
    {
        protected override void Init()
        {
            this.testInstance = new TaskService();
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }
    }

    public class SubtaskUnitTest: ProjectUnitTest
    {
        protected override void Init()
        {
            this.testInstance = new SubtaskService();
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }
    }

    public class CommentUnitTest: ProjectUnitTest
    {
        protected override void Init()
        {
            this.testInstance = new CommentService();
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }

        [TestMethod]
        public void TaskDeadlineTest()
        {
        }
    }

    // TOADD
}
