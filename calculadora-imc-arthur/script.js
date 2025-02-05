function calcularIMC(){
    const Peso = parseInt(document.getElementById('weight').value);
    const Altura = parseFloat(document.getElementById('height').value);
    
    let ImcTotal;

    const resultado = document.getElementById('resultText');
    if(Peso === '' || Altura === ''){
        document.getElementById('resultText').textContent = 'Insira Dados Válidos'
    }
    else{
        ImcTotal = Peso / (Altura*Altura);
    }
    if(ImcTotal < 18.5){
        resultado.innerHTML = `Seu IMC é de: ${ImcTotal.toFixed(2)}(Abaixo do peso)`
    }
    if(ImcTotal > 18.5 && ImcTotal < 24.9){
        resultado.innerHTML = `Seu IMC é de: ${ImcTotal.toFixed(2)}(Peso Normal)`
    }
    if(ImcTotal > 25 && ImcTotal < 29.9){
        resultado.innerHTML = `Seu IMC é de: ${ImcTotal.toFixed(2)}(Sobrepeso)`
    }
    if(ImcTotal > 30){
        resultado.innerHTML = `Seu IMC é de: ${ImcTotal.toFixed(2)}(Obesidade)`
    }
    if(document.getElementById('weight').value === '' || document.getElementById('height').value ===''){
        const resultado = document.getElementById('resultText');
        console.log(resultado);
        resultado.textContent = `Por favor, insira valores válidos.`
    }
    if(document.getElementById('weight').value === 0 || document.getElementById('height').value === 0){
        const resultado = document.getElementById('resultText');
        console.log(resultado);
        resultado.textContent = `Por favor, insira valores válidos.`
    }
}

function limparCampos(){
    const resultado = document.getElementById('resultText');
    resultado.textContent = "Preencha os campos e clique em Calcular."
    document.getElementById('weight').value = '';
    document.getElementById('height').value = '';
   
}