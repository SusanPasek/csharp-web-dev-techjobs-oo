using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job job5;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            job5 = new Job("Product tester", new Employer("ACME"), new Location(""), new PositionType("Quality Control"), new CoreCompetency(""));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            //if job 2 ID is 1 greater then job 1 ID return true (pass test)
            //if job2.Id == job1.Id + 1
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality Control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
        [TestMethod]
        public void TestToStringOutput()
        {
            string actual = job3.ToString();
            string expected = $"\n" +
                $"ID: {job3.Id}\n" +
                $"Name: {job3.Name}\n" +
                $"Employer: {job3.EmployerName}\n" +
                $"Location: {job3.EmployerLocation}\n" +
                $"Position Type: {job3.JobType}\n" +
                $"Core Competency: {job3.JobCoreCompetency}\n";
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void TestIfFieldIsEmpty()
        {
            string actual = job5.ToString();
            string expected = $"\n" +
                $"ID: {job5.Id}\n" +
                $"Name: {job5.Name}\n" +
                $"Employer: {job5.EmployerName}\n" +
                $"Location: Data not available\n" + 
                $"Position Type: {job5.JobType}\n" +
                $"Core Competency: Data not available\n";
            Assert.AreEqual(actual, expected);
        }
    }
}
