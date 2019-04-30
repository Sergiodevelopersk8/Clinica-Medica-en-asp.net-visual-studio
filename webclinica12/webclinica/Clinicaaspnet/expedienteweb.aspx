<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="expedienteweb.aspx.cs" Inherits="Clinicaaspnet.expedienteweb" %>

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
  <label class="titulo" for="nombre">Expediente clinico <span class="requerido">*</span></label>
  <div>
    <span>
<%--     <asp:TextBox ID="Txtnombre" runat="server" Width="186px"></asp:TextBox>
      <label id="lab">Tipo de Sangre</label>--%>
    </span>

    <span>
    
        <%--<asp:TextBox ID="Txtapellido1" runat="server"></asp:TextBox>
      <label id="lab">Primer apellido</label>--%>
    </span>

    <span>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:Label ID="lab" runat="server" Text="Paciente"></asp:Label>
    </span> 

  <span>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
      <label id="lab">Sangre</label> 
      </span>
      <span>
        <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
      <label id="lab">Padecimiento</label> 
      </span>
      <span>
        <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
      <label id="lab">Vicio</label> 
      </span>
      <span>
        <asp:DropDownList ID="DropDownList5" runat="server"></asp:DropDownList>
      <label id="lab">Alergia</label> 
      </span>
      <span>
        <asp:DropDownList ID="DropDownList6" runat="server"></asp:DropDownList>
      <label id="lab">Analisis</label> 
      </span>
  </div>
 
</li>

<li>
  &nbsp;<div>
    <span>
     <%-- <input id="direccion" name="direccion" value="" />
       --%> <%--&nbsp;</span><span><asp:TextBox ID="Txtdireccion" runat="server"></asp:TextBox>
      <label id="lab">Direccion</label>--%>
    </span>

    <span>&nbsp;
    </span>

    <span>
    
    </span>
  </div>

  
</li>

<li>
  

  <div>
    <span>
        <%--<asp:DropDownList ID="Listgrupo" runat="server" Width="138px">

      </asp:DropDownList>--%>
       <%-- <asp:DropDownList ID="Dropgrup" runat="server"></asp:DropDownList>--%>

        <%--<asp:TextBox ID="txtelefono" runat="server"></asp:TextBox>--%>
        <option value=""></option>
       <%-- <option value="pais1">País 1</option>
        <option value="pais2">País 2</option>
        <option value="pais3">País 3</option>--%>
      </select>
  <%-- <label id="lab">Telefono</label>--%>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Image" UpdateImageUrl="~/Imagenes/button_blank_blue_14984.png" />
            </Columns>
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
      <asp:Button ID="Button3" runat="server" Text="Mostrar" OnClick="Button3_Click" />
      <br />
    </span>
  </div>

 
</li>



  <div id="grid22">
   

    
      <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
   

    
  </div>



   <%-- <li>

    </li>--%>
<li>

</li>
   <%-- <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />--%>
  <%--  <asp:Button ID="Button1" runat="server" Text="Insertar" OnClick="Button1_Click" />
  --%>  <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
</ul>
           <ul>
               <li>
                    <div id="TodosHorarios">
          
              
        </div>
               </li>
           </ul>
    </form>
</body>
</html>
