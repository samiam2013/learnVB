Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace learnVB
    <TestClass>
    Public Class UnitTest1
        <TestMethod>
        Sub TestElementary1()
            Const sw As String = "Hello World"
            Dim returned As String = elementary1()
            Assert.AreEqual(sw, returned)

        End Sub
    End Class
End Namespace

