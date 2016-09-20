using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerShellLibrary.Crm.CmdletProviders.Nodes;

namespace PowerShellLibrary.Crm.CmdletProviders.Tests.Nodes {
  [TestClass]
  public class PathSegementTests {
    [TestMethod]
    public void TestParsingPathSegmentContainingCrmDrive() {
      PathSegment pathSegment = new PathSegment(@"CrmDrive:\Playground\Entities");

      Assert.AreEqual(@"CrmDrive", pathSegment.CrmDrive);
      Assert.AreEqual(@"\Playground\Entities", pathSegment.Path);
    }

    [TestMethod]
    public void TestParsingPathSegmentWithoutContaingCrmDrive() {
      PathSegment pathSegment = new PathSegment(@"\Playground\Entities");

      Assert.IsNull(pathSegment.CrmDrive);
      Assert.AreEqual(@"\Playground\Entities", pathSegment.Path);
    }

    [TestMethod]
    public void TestReplaceSlashUsingBackSlash() {
      PathSegment pathSegment = new PathSegment("CrmDrive:/Playground/Entities");

      Assert.AreEqual(@"CrmDrive:\Playground\Entities", pathSegment.FullPathSegment);
    }

    [TestMethod]
    public void TestEnsureStartingBackSlash() {
      PathSegment pathSegment = new PathSegment(@"Playground\Entities");

      Assert.AreEqual(@"\Playground\Entities", pathSegment.FullPathSegment);
    }

    [TestMethod]
    public void TestToStringEqualsValue() {
      PathSegment pathSegment = new PathSegment(@"\Playground\Entities");

      Assert.AreEqual(pathSegment.ToString(), pathSegment.FullPathSegment);
    }

    [TestMethod]
    public void TestSegments() {
      PathSegment pathSegment = new PathSegment(@"\Playground\Entities");

      Assert.AreEqual(2, pathSegment.Segments.Count());
      Assert.AreEqual("Playground", pathSegment.Segments.First());
      Assert.AreEqual("Entities", pathSegment.Segments.Last());
    }

    [TestMethod]
    public void TestCrmDrive() {
      PathSegment pathSegment = new PathSegment(@"CrmDrive:\Playground\Entities");

      Assert.AreEqual("CrmDrive", pathSegment.CrmDrive);
    }

    [TestMethod]
    public void TestGetPathDescendants() {
      PathSegment pathSegment = new PathSegment(@"CrmDrive:\Playground\Entities\account");

      IEnumerable<string> paths = pathSegment.GetPathDecendants();

      Assert.AreEqual(3, paths.Count());
      Assert.AreEqual(@"\Playground", paths.Take(1).Single());
      Assert.AreEqual(@"\Playground\Entities", paths.Skip(1).Take(1).Single());
      Assert.AreEqual(@"\Playground\Entities\account", paths.Skip(2).Take(1).Single());
    }

    [TestMethod]
    public void TestPathEqualsPath() {
      PathSegment pathSegment = new PathSegment(@"CrmDrive:\Playground\Entities\account");

      bool isEqual = pathSegment.Equals(@"\Playground\Entities\account");

      Assert.IsTrue(isEqual);

      isEqual = pathSegment.Equals(@"\Playground\Entities\Account");

      Assert.IsTrue(isEqual);
    }

    [TestMethod]
    public void TestAddPath() {
      PathSegment firstSegment = new PathSegment(@"CrmDrive:\Playground\Entities");
      PathSegment secondSegment = new PathSegment(@"account");

      PathSegment childPathSegment = firstSegment + secondSegment;

      Assert.AreEqual(@"\Playground\Entities\account", childPathSegment.Path);
    }

    [TestMethod]
    public void TestAddOperation() {
      PathSegment rootSegment = new PathSegment(@"CrmDrive:\Playground\Entities");
      PathSegment childSegment = new PathSegment("account");

      PathSegment combinedSegment = rootSegment + childSegment;

      Assert.AreEqual(@"\Playground\Entities\account", combinedSegment.Path);
    }
  }
}