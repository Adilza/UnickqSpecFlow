﻿#language: pt-BR
Funcionalidade: Formulario de Contato
	Eu como usuário, preciso contactar o prestador de serviço
	Para que seja necessário um possível retorno
	Preciso preencher as informações do formulário corretamente.

Contexto: 
	Dado que eu esteja no site jobmidia
	E navego em formulário de contato

@Browser:FirefoxDocker @Browser:IEDocker @Browser:IE @Browser:ChromeDocker @Browser:Edge
Cenario: Preenchimento do formulario corretamente
	E informo todos os dados
	 |Nome		|Email					|Telefone	  | Mensagem		  |
	 |Franklin	|franklinjob@hotmail.com|(21)991475281|	Teste de Mensagem |
	Quando envio os dados
	Entao recebo a mensagem de sucesso 'Sua mensagem foi enviada com sucesso.'

	
@Browser:PhantomDocker @negativo
Cenario: Preenchimento do formulario com email incorreto
	E informo todos os dados
	Mas informo o email incompleto
	|Nome		|Email					|Telefone	  | Mensagem		  |
    |Franklin	|franklinjob@           |(21)991475281|	Teste de Mensagem |
	Quando envio os dados
	Entao recebo a mensagem de validação do e-mail 'Formato de e-mail inválido'

@Browser:IE @Browser:Chrome @Browser:Firefox @negativo
Cenario: Preenchimento do formulario sem mensagem
	E informo todos os dados
	|Nome		|Email					|Telefone	  | Mensagem		  |
    |Franklin	|franklinjob@hotmail.com|(21)991475281|					  |
	Mas não informo mensagem
	Quando envio os dados
	Entao recebo a mensagem de validação de mensagem 'Por favor informe uma mensagem.'

@Browser:IE
Cenario: Preenchimento do formulario telefone incorreto
	E informo todos os dados
	|Nome		|Email					|Telefone	  | Mensagem		  |
    |Franklin	|franklinjob@hotmail.com|			  |	Teste de Mensagem |
	Mas não informo telefone
	Quando envio os dados
	Entao recebo a mensagem de validação de telefone 'Por favor informe seu telefone.'