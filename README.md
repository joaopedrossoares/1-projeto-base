# Guia para desenvolvimento do projeto.
### Caso seja sua primeira vez no github siga os passos abaixo. Caso contrário passe para o próximo tópico.
*Caso o computador não possua o git instalado, favor instalar.* [Link para instalação](https://git-scm.com/download/win)
```
git config --global user.name "Seu nome"
git config --global user.email "seuemail@email.com"
```
Para clonar o projeto é necessário que sejam executados tais comandos.
```
git clone https://github.com/joaopedrossoares/vouf.git
```
Após o projeto clonado execute o comando para adicionar um remote ao seu git local.
```
git remote add origin https://github.com/joaopedrossoares/vouf.git
```
Execute o seguinte comando para conferir se está correto. 
```
git remote -v
```
Execute o seguinte comando para atualizar seu repositório local.
```
git pull origin master
```
### Para realizar suas tarefas é necessário que uma branch seja criada.

Para criar uma branch execute o comando: 
```
git checkout -b NOMEDASUABRANCH
```

#### Execute suas tarefas... Quando terminá-las, executar os seguintes comandos:
```
git pull origin master
git status
git add nomeDoArquivoModificado nomeDoOutroArquivo ePorAiVai
git status
git commit -m "mensagem explicando"
git push origin NOMEDASUABRANCH
```


