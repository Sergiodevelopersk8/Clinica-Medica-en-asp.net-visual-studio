﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menuclinicaweb.aspx.cs" Inherits="Clinicaaspnet.Menuclinicaweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link rel="stylesheet" href="parabotones/fonts/style.css">
 <link rel="stylesheet" href="parabotones/estilopavdos.css">
  <link rel="stylesheet" href="parabotones/redess.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
    
h1 span{
color:orangered;
margin-right: 20px;
font-size: 80px;          
font-size: 80px;          
     }   
     h1{
         color:#cd486b;
         font-family:fantasy;
     }
</style>

</head>
<body>
    <form id="form1" runat="server">
        <h1><span class="icon-eye"></span> Clinica </h1> 
<header>
        <nav>
           
            <ul>
               
                <li><a href='Pacienteweb.aspx'><span class="primero"><i class="icon icon-home"></i></span>Paciente</a>
               
                </li>
                <li><a href='Adiccionweb.aspx'><span class="segundo"><i class="icon icon-eye"> </i></span>adiccion</a>
                  
                    <ul>
                   
                </ul>
                </li>
                <li><a href='Alergiasweb.aspx'><span class="tercero"><i class="icon icon-eye"></i></span>Alergias</a>
              <link rel='analisisweb.aspx' href='Profesform.aspx'>
                </li>
                <li><a href='expedienteweb.aspx'><span class="cuarto"><i class="icon icon-eye"></i></span>Expediente</a></li>
                
                <li>
                   <a href=' Padecimientoweb.aspx'><span class="quinto"><i class="icon icon-eye"></i></span>Padecimiento</a></li>
                   <li>
                   <a href=' analisisweb.aspx'><span class="quinto"><i class="icon icon-eye"></i></span>Analisis</a></li>
                 
                <li>
                   <a href=' sangreweb.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Sangre</a></li>
                 <li>
                   <a href=' Recetafechaweb.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Recetas </a></li>
                 <li>
                   <a href=' mostrar.aspx'><span class="quinto"><i class="icon icon-ticket"></i></span>Mostrar </a></li>
                
                
            </ul>
        </nav>
        <div class="social">
    <ul>
        <li><a href='' target="_blank" class="icon-facebook"></a></li>
         <li><a href='Alumnolaboform.aspx' target="_blank" class="icon-instagram"></a></li>
          <li><a href='Asistenciaprof.aspx' target="_blank" class="icon-twitter"></a></li>
            <li><a href="https://www.tumblr.com/blog/sersk8cbr" target="_blank" class="icon-tumblr"></a></li>
            <li><a href="mailto:davidcidgar@gmail.com"  class="icon-mail"></a></li>
            <li> </li>
            
            
    </ul>
    
</div>



</header>

    </form>
</body>
</html>