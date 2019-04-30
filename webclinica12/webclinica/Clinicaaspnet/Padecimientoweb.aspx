<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Padecimientoweb.aspx.cs" Inherits="Clinicaaspnet.Padecimientoweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link rel="stylesheet" href="parabotones/Alumnosfc.css"/>
    <link rel="stylesheet" href="parabotones/estilopavdos.css"/>
    <link rel="stylesheet" href="parabotones/gridhoja.css"/>
    
    <link rel="stylesheet" href="parabotones/fonts/style.css"/>
   
    <title></title>
      <script src="Script_Jquery/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="Script_Jquery/jquery-tooltip/jquery.tooltip.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function InitializeToolTip() {
            $(".grilla").tooltip({
                track: true,
                delay: 0,
                showURL: false,
                fade: 100,
                bodyHandler: function () {
                    return $($(this).next().html());
                },
                showURL: false
            });
        }
    </script>
    <script type="text/javascript">
        $(function () {
            InitializeToolTip();
        })
    </script>
    <style type="text/css">
        #tooltip {
            position: absolute;
            z-index: 3000;
            border: 1px solid #111;
            background: url(/Imagenes/pccolor.gif);
            padding: 5px;
            color: red;
            border-radius: 10px;
            width: 350px;
            border: 0px;
            font-size: 18px;
        }

            #tooltip h3, #tooltip div {
                margin: 0;
            }
    </style>
    <script src="Script_Jquery/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="Script_Jquery/jquery-tooltip/jquery.tooltip.min.js" type="text/javascript"></script>

</head>
<body>
   <%-- <asp:Button ID="Button2" runat="server" Text="Button" />--%>
     <nav>
           
            <ul>
               
                <li><a href='Menuclinicaweb.aspx'><span class="primero"><i class="icon icon-home"></i></span>Inicio</a>
               </ul>
        </nav>
                
    <form id="form1" runat="server">
       <div id="contenedor">

<h2>Formulario de alta</h2>

<%--<form method="post" action="#">--%>
<ul>
<li>
  <label class="titulo" for="nombre">Padecimiento <span class="requerido">*</span></label>
  <div>
    <span>
     <asp:TextBox ID="Txtnombre" runat="server" Width="186px"></asp:TextBox>
      <label id="lab">Padecimientos</label>
    </span>

    <span>
    
        <%--<asp:TextBox ID="Txtapellido1" runat="server"></asp:TextBox>
      <label id="lab">Primer apellido</label>--%>
    </span>

    <span>
     <%-- <input id="apellido2" name="apellido2" value="" />--%>
          <%--<asp:TextBox ID="Txtapellido2" runat="server" OnTextChanged="TextBox2_TextChanged" Height="19px" Width="247px"></asp:TextBox>--%>
       <%-- <asp:TextBox ID="Txtapellido2" runat="server"></asp:TextBox>
      <label id="lab">Segundo apellido</label>--%>
    </span>
  </div>

 
</li>

<li>
  <%--<%--<%--

</li>
   <%-- <li>

    </li>--%>
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
<li>

</li>
   <%-- <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />--%>
  <%--  <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
   --%> <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
</ul>
           </form>
</body>
</html>

