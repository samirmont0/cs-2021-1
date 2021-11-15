**1. Qual o comando para obter a versão instalada do Git?**      
    
    Com o comando git version.

**2. Qual o efeito da execução de cada um dos comandos abaixo?**

    a) Abre um manual no próprio terminal com os comandos principais do git.
    b) Abre um navegador com manual do git checkout(é possível fazer com outros comandos).
    c) Abre um navegador com manual do git merge(é possível fazer com outros comandos).
    d) Cria um repositório Git sem nada ou reinicia um pré-existente.
    e) Adiciona todos arquivos para a staging area, preparado para o próximo commit.
    f) Adiciona os arquivos com alteração para a staging area, preparado para o próximo commit.
    g) Lista as config. do usuário.
    h) Renomeia o arquivo, o primeiro é o nome atual, o segundo nome é o que vai passar a ser chamado
    i) Volta o branch para o commit anterior.
    j) Mostra os últimos 27 commits.

**3. O fluxo “clássico” de interação com o Git é algo como “alterar um ou mais arquivos”, “acrescentar essas mudanças para serem contemplados no próximo commit” e, finalmente, executar um “commit”. Quais os comandos necessários para realizar os dois últimos “passos” desse fluxo?**

    git add arquivo...
    git commit -m "Mensagem"

**4. Qual o comando deve ser executado para identificar o que foi alterado desde o último “commit”?**
    
    Com o comando git show.
    
**5. Em um dado repositório, arquivos simplesmente copiados para lá, ou seja, _untracked_, podem ser exibidos/identificados com que comando?**
    Com o comando git status.

**6. Qual o comando para efetuar um _commit_?**

    Com o comando git commit -m "Mensagem do commit".

**7. Qual o comando que devemos empregar para descartar mudanças ocorridas no arquivo teste.txt, por exemplo?**

    Com o comando git checkout -- teste.txt.

**8. O que deve ser feito para que um determinado diretório do seu repositório seja ignorado pelo Git? Faça uma busca por **.gitignore**.**

    Criando um arquivo .gitignore e fazendo a configuração dele para falar o que vai ser ignorado.

**9. O que acontece se o seu repositório local for acidentalmente removido?**

    Haverá perda do repositório local, mas se já estiver no remoto, é so dar um clone novamente, contando que tudo tivesse sido subido, nada será perdido.

**10. Como clonar um repositório remoto?**
    
    Com o comando git clone https://github...

**11. Em alguns cenários **git log** pode produzir extensos resultados. Se houver interesse em visualizar o histórico de um repositório, onde cada mudança é fornecida exatamente em uma única linha, qual o comando que deve ser empregado?**

    Com o comando git log --pretty=oneline 


**12. Em qual arquivo o Git armazena informações de configuração empregadas por usuário?**

    Na pasta \.git, no arquivo config

**13. Qual o comando para criar um repositório local?**

    Com o comando git init

**14. Qual o nome do diretório criado pelo Git quando se executa o comando **git init**?**

    Uma pasta oculta chamada .git

**15. Qual o comando para adicionar todos os arquivos modificados? (Aqueles para os quais **git status** identificam como **modified**?)**

    Com o comando git add -all

**16. O Git faz uso do valor de hash conhecido por SHA1. O que isto significa? Qual o propósito? O que é SHA1?**

O git usa SHA com o propósito de segurança e de identificação de alterações nos arquivos. SHA1 é um algoritmo que recebe alguns dados como entrada e gera uma string única de 40 caracteres através desses dados. Ou seja, nenhuma outra entrada de dados deveria produzir o mesmo hash. Porém, caso a mesma entrada de dados seja usada, ela sempre irá produzir o mesmo hash.
Isso é extremamente importante, pois o número de revisão do git é nessa hash SHA1, então mesmo que várias pessoas estejam usando o mesmo repositório, se o número de revisão for igual para todas elas, isso significa que todos estão trabalhando naquele mesmo conjunto de arquivos. Isso traz maior segurança, pois se qualquer alteração for realizada em qualquer bit que seja, ou mesmo durante a transferência dos arquivos, se ocorrer qualquer perda de bits, o git irá identificar.

**17. Qual a palavra para indicar o último _commit_ em vez do valor de hash SHA1 correspondente?**

    -abbrev-commit 

**18. Quando se cria dois arquivos usando um editor de texto qualquer e, na sequência, executamos o comando **git add -u**, os dois arquivos criados passam de _untracked_ para _new file_?**

Não, já que o git add -u adiciona os arq. com edição e que o Git tem controle.

**19. Qual o efeito da execução dos dois comandos abaixo, nesta ordem, em um dado repositório?** 
    
    O primeiro reseta a HEAD para o commit que for desejado. Os arquivos que sofreram modificação, ficaram com mudanças para ser commitadas.
    O segundo, o índice e a working tree são resetados e as mudanças serão perdidas.
    
**20. Após o emprego de um ambiente integrado de desenvolvimento (IDE), é comum a criação de arquivos e diretórios. Qual o comando que podemos empregar para remover arquivos e diretórios _untracked_?**

    Com o comando git clean -f

**21. Qual o nome do arquivo no qual podemos inserir a indicação para o Git de arquivos e diretórios a serem ignorados?** 
    
    É o arquivo .gitignore

**22. Quando se cria o arquivo _MinhaClasse.class_ em um dado diretório e desejamos que arquivos com a extensão .class, como neste caso, sejam ignorados por todos os membros de uma equipe que estão contribuindo com um dado projeto, como devemos proceder?**

    Colocando-se *.class

**23. jQuery é uma famosa biblioteca em JavaScript. Consulte detalhes em [jQuery](http://jquery.com). O repositório correspondente encontra-se em [gitRep](https://github.com/jquery/jquery.git). Faça o clone deste repositório.**
    
    Feito.

**24. No repositório **jqueryrepo**, criado no passo anterior, qual o efeito do comando
**git shortlog -sne**?**

    Mostra resumo do último commit, mostrando nome e email do autor.

**25. No repositório **jqueryrepo**, qual o efeito de **git remote -v**?**

    Mostra a URL do diretório jqueryrepo

**26. Um repositório Git pode ser etiquetado ao longo do tempo. Ou seja, _commits_ específicos podem ser “marcados” ou “etiquetados” para facilitar referências posteriores. Para listar todas as “etiquetas” (_tags_) estabelecidas para um dado repositório, qual comando deve ser executado?**

    Executado o comando git tag

**27. Caso um dato repositório retorne muitas “marcas” ou “etiquetas” para o comando **git tag**, como retornar apenas aquelas que atendem a determinado padrão, por exemplo, iniciadas por 2.0?**


    O comando seria git tag -l "2.0"

**28. Qual o efeito do comando **git tag -a 3.4-gold -m “minha versão ouro”**?**

    Cria uma tag "3.4-gold" com uma mensagem de tagging “minha versão ouro”.

**29. Após executado o comando acima, qual o efeito de **git show 3.4-gold**?**

    Resumo dos dados da tag, como quem criou, horário que foi criada e entre outros.

**30. O que o comando **git push origin 3.4-gold** teria como efeito?**
    
    

**31. Após executar um commit, qual o efeito de **git commit --amend**?**

    Permite alterar o último commit, como por exemplo adicionar alterações.

**32. Após executar **git add x.txt**, qual o efeito de **git reset HEAD x.txt**?**

    Faz com que o x.txt seja retirado da staging area, e se for realmente querer commitar esse arquivo de texto, terá que dar um git add x.txt novamente.

**33. Após alterar o conteúdo de um arquivo committed em passo anterior, qual o efeito do comando **git checkout -- a.txt**?**

    Desfaz as mudanças que foram feitas depois do commit.

**34. Qual a diferença entre os comandos **git reset HEAD a.txt** e **git checkout -- a.txt**?**

    O primeiro reseta a cabeça da branch, fazendo com que o arquivo a.txt volte ao estado dele ao que tava no último commit, e o segundo descarta as mudanças feitas no arquivo.