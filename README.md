O sistema consiste em consultar e cadastrar com sucesso as consultas que retornaram dados com sucesso.

Antes de executar o sistema é necessário abrir o arquivo chamado appsettings.json e configurar algumas informações:


Data Source=.\\SQLEXPRESS; Initial Catalog=GestaoCompras; User ID=NomeUsuario; Password=SenhaUsuario; Integrated Security=False; Persist Security Info=True; MultipleActiveResultSets=true;

Para isso execute o Visual Studio e encontre o console Package Manager Console. Normalmente ele é encontrado no menu do software e está na parte inferior das Ferramentas(Tools). 
Após configurar o arquivo e encontrar oconsole Package Manager Console  é necessário executar o comando update-database para que o Entity Framework crie o banco e as suas tabelas.
