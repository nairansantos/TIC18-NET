Objetivo:
Desenvolver um sistema de gerenciamento de estoque que utiliza conceitos de tuplas, 
expressões lambda, LINQ e tratamento de exceções.
Desenvolvimento
• Produto:
o Crie uma tupla representando um produto no estoque, contendo os 
seguintes elementos: código do produto, nome do produto, quantidade 
em estoque e preço unitário.
• Cadastro de Produtos:
o Permita que o usuário cadastre novos produtos no estoque, informando 
código, nome, quantidade e preço.
o Utilize tratamento de exceções para lidar com possíveis erros durante o 
cadastro, como entradas inválidas.
• Consulta de Produtos:
o Implemente uma função que permita ao usuário buscar um produto pelo 
código. Caso o produto não exista, lance uma exceção personalizada 
indicando que o produto não foi encontrado.
• Atualização de Estoque:
o Crie funções que permitam a atualização da quantidade em estoque de um 
produto, levando em consideração entradas ou saídas. Faça o tratamento
Residência em Tecnologia da Informação e Comunicação
lógico para lidar com casos em que a quantidade atual seja insuficiente 
para uma saída.
• Relatórios:
o Utilize LINQ para gerar 3 relatórios:
1. Lista de produtos com quantidade em estoque abaixo de um 
determinado limite informado pelo usuário.
2. Lista de produtos com valor entre um mínimo e um máximo informados
pelo usuário.
3. Informar o valor total do estoque e o valor total de cada produto de 
acordo com seu estoque.
Dicas:
• Utilize expressões lambda para cálculos específicos, como o valor total em 
estoque de um produto.
• Implemente consultas LINQ para gerar relatórios personalizados.
• Utilize tratamento de exceções para garantir uma experiência de usuário mais 
robusta e amigável.
