function validarUser(form) {

    caixa_erro_Nome = document.querySelector(".msg-erro-Nome");
    caixa_erro_Nome.style.display = 'none';
    caixa_erro_Email = document.querySelector(".msg-erro-Email");
    caixa_erro_Email.style.display = 'none';
    caixa_erro_Login = document.querySelector(".msg-erro-Login");
    caixa_erro_Login.style.display = 'none';
    caixa_erro_Senha = document.querySelector(".msg-erro-Senha");
    caixa_erro_Senha.style.display = 'none';

    if (document.getElementById("NomeUser").value.length < 5) {

        caixa_erro_Nome.innerHTML = "Por favor informe o seu nome!";
        caixa_erro_Nome.style.display = 'block';
        document.getElementById("NomeUser").focus();
        return false;

    }

    if (document.getElementById("LoginUser").value.length < 5) {

        caixa_erro_Login.innerHTML = "Login invalido!";
        caixa_erro_Login.style.display = 'block';
        document.getElementById("LoginUser").focus();
        return false;

    }

    if (document.getElementById("SenhaUser").value.length < 8) {

        caixa_erro_Senha.innerHTML = "Senha contem caracteres insuficientes!";
        caixa_erro_Senha.style.display = 'block';
        document.getElementById("SenhaUser").focus();
        return false;

    }

    if (document.getElementById("EmailUser").value == "") {

        caixa_erro_Email.innerHTML = "Informe seu email!";
        caixa_erro_Email.style.display = 'block';
        document.getElementById("EmailUser").focus();
        return false;
    }
}



function validarProd(form) {

    caixa_erro_Nome = document.querySelector(".msg-erro-Nome");
    caixa_erro_Nome.style.display = 'none';
    caixa_erro_Tipo = document.querySelector(".msg-erro-Tipo");
    caixa_erro_Tipo.style.display = 'none';
    caixa_erro_ValorUnitario = document.querySelector(".msg-erro-ValorUnitario");
    caixa_erro_ValorUnitario.style.display = 'none';

    if (document.getElementById("NomeProduto").value.length < 5) {

        caixa_erro_Nome.innerHTML = "Por favor informe o nome do produto!";
        caixa_erro_Nome.style.display = 'block';
        document.getElementById("NomeProduto").focus();
        return false;

    }

    if (document.getElementById("ValorUnitario").value.length < 1) {

        caixa_erro_ValorUnitario.innerHTML = "informe um valor!";
        caixa_erro_ValorUnitario.style.display = 'block';
        document.getElementById("ValorUnitario").focus();
        return false;

    }

    if (document.getElementById("TipoProduto").value == "") {

        caixa_erro_Email.innerHTML = "Informe um tipo!";
        caixa_erro_Email.style.display = 'block';
        document.getElementById("TipoProduto").focus();
        return false;
    }
}






