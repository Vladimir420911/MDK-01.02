using System;
using System.Linq;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProjectMoq
{
    [TestClass]
    public class MoqTesting
    {
        [TestMethod]
        public void GetAvgGrade_ReturnsAvgGrade()
        {
            var mockRepo = new Mock<IStudentRepo>();
            var student = new Student() { Name = "AAA", Grades = new int[] { 2, 3, 5 } };

            double expected = student.Grades.Average();

            mockRepo.Setup(r => r.GetAvgGrade(student.Grades))
                    .Returns(expected);

            var studentService = new StudentService(mockRepo.Object);

            var result = studentService.StudentAvgGrade(student.Grades);

            Assert.AreEqual(expected, result);
        }
    }
}
