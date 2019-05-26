using NUnit.Framework;
using StaticAbstraction;
using StaticAbstraction.IO;
using StaticAbstractionTests.TestingWorkspace;
using System.IO;


/// <summary>
/// General note: these test are not 'clean' unit tests in that they have to, by their very nature, modify files in the local file system in 
/// order to validate the underlying functionality.  This is 100% intentional.
/// </summary>

namespace StaticAbstractionTests.IO
{
    [TestFixture]
    public class DirectoryInfoTests
    {
        private Workspace _workspace;
        private string _testFolder;
        private static long _testCount = 0;

        [SetUp]
        public void Setup()
        {
            _workspace = new Workspace();
            _testFolder = _workspace.CreateDirectoryForTest($"test_folder_{_testCount++}");
        }

        [TearDown]
        public void Teardown()
        {
            _workspace.Dispose();
        }


        [Test]
        public void ExistingFolder_property_tests()
        {
            ComparePropertiesForFolder(_testFolder);
        }


        [Test]
        public void Create_test()
        {
            var newDirName = Path.Combine(_testFolder, "SomeFolder");

            var testDir = new StAbDirectoryInfo(newDirName);

            Assert.IsFalse(Directory.Exists(newDirName));

            testDir.Create();

            Assert.IsTrue(Directory.Exists(newDirName));
            ComparePropertiesForFolder(newDirName);
        }


        [Test]
        public void Delete_test()
        {
            var newDirName = Path.Combine(_testFolder, "SomeFolder");


            Directory.CreateDirectory(newDirName);

            var testDir = new StAbDirectoryInfo(newDirName);
            testDir.Delete();

            Assert.IsFalse(Directory.Exists(newDirName));
        }


        protected void ComparePropertiesForFolder(string path)
        {
            var info = new StAbDirectoryInfo(path);
            var actual = new DirectoryInfo(path);

            Assert.AreEqual(actual.Exists, info.Exists);
            Assert.AreEqual(actual.Name, info.Name);

            Assert.IsNotNull(info.Parent);
            Assert.IsNotNull(info.Root);

            Assert.AreEqual(actual.Parent.FullName, info.Parent.FullName);
            Assert.AreEqual(actual.Root.FullName, info.Root.FullName);
            Assert.AreEqual(actual.Attributes, info.Attributes);
            Assert.AreEqual(actual.FullName, info.FullName);
            Assert.AreEqual(actual.Extension, info.Extension);

            Assert.AreEqual(actual.LastAccessTime, info.LastAccessTime);
            Assert.AreEqual(actual.LastAccessTimeUtc, info.LastAccessTimeUtc);
            Assert.AreEqual(actual.LastWriteTime, info.LastWriteTime);
            Assert.AreEqual(actual.LastWriteTimeUtc, info.LastWriteTimeUtc);

            Assert.AreEqual(actual.CreationTime, info.CreationTime);
            Assert.AreEqual(actual.CreationTimeUtc, info.CreationTimeUtc);
        }
    }
}
