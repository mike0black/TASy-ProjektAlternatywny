<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SprzedaneWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Przedmioty</title>

    <link href="Style.css" rel="stylesheet" type="text/css" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.js" 
            type="text/javascript"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.18/jquery-ui.js" 
            type="text/javascript" ></script>
        <script type="text/javascript">
            $(function () {
            $("#<%= tbPrzedmiotNazwa.ClientID %>").autocomplete({
                source: function (request, response) {
             $.ajax({
                cache: false,
                type: "GET",
                async: false,
                url: "http://localhost:1622/SprzedaneService.svc/przedmioty/" + request.term, //nope?
                dataType: "json",
                success: function (data) {
                    response( $.map( data, function( item ) {
                        return {
                            label: item.Nazwa,
                            value: item.Kategoria
                        }
                    }));
                },
                error: function (xhr) {
                    alert(xhr.responseText);
                }
             });
            },
            select: function (event, ui) {
                $("<div/>").text("Selected: " + ui.item.value).prependTo("#log");
                $("#log").scrollTop(0);
            }
        });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labPrzedmiotNazwa" runat="server" Text="Przedmiot : " />
            <asp:TextBox ID="tbPrzedmiotNazwa" runat="server" />
        <div id="log" class="log-content" ></div>
        </div>
    </form>
</body>
</html>
