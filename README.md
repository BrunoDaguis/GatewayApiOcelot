# API Gateway com Ocelot
Projeto feito utilizando .Net Core para as API's e Ocelot como API Gateway para plataforma .NET.

A finalidade desse projeto é simular dois microserviços sendo chamados a partir de um unico ponto de entrada.
No caso, temos os seguintes endpoints simulando microserviços diferentes:

1. https://localhost:44326/api/payment/getall
2. https://localhost:44366/api/product/getall

Os dois métodos acima podem ser chamados a partir do gateway feito em ocelot, pelo endereço:

1. https://localhost:44389/api/product/getall
2. https://localhost:44389/api/payment/getall
3. https://localhost:44389/api/ProductAndPayments/getall
