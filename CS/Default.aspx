<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DashboardGridHyperlink._Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>

    <style type="text/css">
        html, body, form {  
            height: 100%;  
            margin: 0;  
            padding: 0;  
            overflow: hidden;  
        }
    </style>
    <script type="text/javascript">
        //<![CDATA[
        function onBeforeRender(s, e) {
            var dashboardControl = s.GetDashboardControl();

            dashboardControl.registerExtension(new GridHyperlinkOptionsExtension(dashboardControl));
        }
        //]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" DashboardStorageFolder="~/App_Data/Dashboards" Height="100%">
            <ClientSideEvents BeforeRender="onBeforeRender" />
        </dx:ASPxDashboard>
    </form>
    <script src="GridHyperlinkOptionsExtension.js"></script>
</body>
</html>