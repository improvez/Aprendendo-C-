1) fazer checkout em seu repo local para branch main
R) git checkout master

2) baixar as atualizações do repo remoto em main para o repo local.
R)git pull origin main

3) crie uma nova branch a partir de main para a aula de hoje seguindo 
padrão de nomenclatura
R)git checkout -b feature/240304_01

4) inclua um comentário no código para ele sofrer uma pequena alteração.
R)create md.

5) adicione esta alteração ao rastreio do git
R)git add .

6) crie um checkpoint 
R)git commit -m "aula de hoje"

7) envie a nova branch local para o repo remoto.
R)git push origin feature/240304_01


lista de comandos para começar a aula:

git status
git checkout master
git pull origin main
git status
git checkout -b "aula de hoje"
// adicionar alguma coisa
git status
git add .
git commit -m "aula 03"
git push origin (nome da branch)

.