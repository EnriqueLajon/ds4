<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Suma de Números</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Suma de dos números</h2>
        
        <p>
            Número 1: 
            <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
        </p>
        
        <p>
            Número 2: 
            <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
        </p>
        
        <p>
            <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
        </p>
        
        <p>
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </p>
    </form>
    
    <script runat="server">
        protected void btnSumar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            double resultado = numero1 + numero2;
            
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }
    </script>
</body>
</html>