<h1>PollProject</h1>
<h3>Projetos:</h3>
<ul>
  <li><b>WebApp</b>: Contém os endpoints da API</li>
  <li><b>IoC</b>: Contém as configurações para injeção de dependência</li>
  <li><b>Infra</b>: Contém as configurações de infraestrutura</li>
  <li><b>Model</b>: Contém as entidades representantes de banco e transferência de dados</li>
  <li><b>Business</b>: Contém as regras de negócio</li>
  <li><b>Data</b>: Contém as regras a nível de acesso ao banco</li>
</ul>
<br/>
<h3>Banco de dados:</h3>
<p>O banco de dados foi criado localmente utilizando SQLServer, com Windows Authentication</p>
<p>Caso o banco seja criado diferente do mencionado acima, alterar a <b>connectionstring</b> correspondente no arquivo <b>appsettings.json</b>, contido no projeto <b>WebApp</b></p>
<p>Os scripts necessários para a criação do banco estão contidos no arquivo PollDataBaseScripts.sql:</p>
