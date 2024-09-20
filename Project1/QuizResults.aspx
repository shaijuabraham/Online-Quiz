<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuizResults.aspx.cs" Inherits="Project1.QuizResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="QuizResult.css" rel="stylesheet"/>
    <title>Finial Grade</title>
</head>
<body style="height: 403px">
    <form id="form1" runat="server">
        <h1 class="header">----------------------- Your Score -----------------------</h1>
        <div class="container">
        <div class="studentinfo">
          <asp:Label ID="lblStudentInfo" runat="server" Text="Student Info"></asp:Label>
        </div>
        <div class="finialgradeimg">
            <asp:Label ID="lblFinalGradeimg" runat="server" Text="FinalGradeimg"></asp:Label>
        </div>
        <div class="finialgrade">
             <asp:Label ID="lblFinialGrade" runat="server" Text="FinialGrade"></asp:Label>
        </div>
        </div>
        <h1  class="header">----------------------- Quiz Result -----------------------</h1>
        <div class="answers">
            <asp:Label ID="lblQuestion" runat="server" Text="Question"></asp:Label>
        </div>
    </form>
</body>
</html>
