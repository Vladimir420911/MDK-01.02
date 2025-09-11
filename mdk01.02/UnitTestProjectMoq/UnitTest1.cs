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
            var student = new Student() { Id = 1, Name = "AAA", Group = "A-1", Grades = new int[] { 2, 3, 5 } };

            double expected = student.Grades.Average();
            //double expected = 1.2;

            mockRepo.Setup(r => r.GetAvgGradeById(1))
                    .Returns(expected);

            var studentService = new StudentService(mockRepo.Object);

            var result = studentService.StudentAvgGrade(1);

            Assert.AreEqual(expected, result);
        }
    }
}
