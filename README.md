# Animal Sounds
**Nume student:** Popescu Dragos

## Implementarea problemei AnimalSounds
Pentru implementarea acestei probleme am urmat pasii:

## Branchul principal este main.

### Crearea aplicatiei consola simpla:
Initial am creat o aplicatie consola simpla care nu respecta principiile OOP, pentru a putea lucra la ea si pentru a putea face refactorizare pe aceasta.

### Crearea unui repository pe GitHub:
Am creat un repository pe GitHub pentru a incarca proiectul si pentru a-l gestiona.

### Initializarea repository-ului local:
In terminalul deschis in Visual Studio, am mers la fisierul in care aveam proiectul si am initializat un repository folosind comanda `git init`.

### Adaugarea codului initial in staging:
Am adaugat codul creat initial in staging pentru a-l pregati pentru commit.

### Crearea primului commit cu varianta initiala de cod:
Am creat primul commit cu varianta initiala de cod folosind comanda `git commit -m "Adaugat codul initial"`.

### Asocierea repository-ului local cu cel de pe GitHub:
Am asociat repository-ul local cu cel de pe GitHub, folosind comanda:
`git remote add origin <repository-url>`

### Urcarea codului in branch-ul main:
Am urcat codul in branch-ul principal folosind comanda:
`git branch -M main`  
`git push origin main`

### Crearea unui branch separat pentru refactorizare:
Am lucrat pe un branch separat pentru refactorizarea codului si implementarea principiilor OOP.

### Refactorizarea codului aplicand principii OOP:

- **Crearea interfetei IAnimal:**  
Am creat o interfata IAnimal, care este implementata de fiecare clasa de animal.

- **Crearea de clase separate pentru fiecare animal:**  
Am creat clase separate pentru fiecare animal (ex: Cow, Dog, Cat), fiecare implementand interfata IAnimal.

- **Modificarea Program.cs pentru a folosi lista de obiecte OOP:**  
In Program.cs, am folosit o lista de obiecte de tipul IAnimal si am apelat metoda MakeSound() pentru fiecare obiect.

### Salvarea modificarilor si urcarea pe GitHub:
Dupa refactorizare, am salvat modificarile si le-am trimis pe GitHub.

### Schimbarea branch-ului pe GitHub:
Am schimbat branch-ul pe GitHub pentru a lucra pe varianta refactorizata (ex: refactoring-branch), iar in main am pastrat varianta initiala.

### Crearea unui Pull Request:
Am creat un Pull Request pentru a propune modificarile si pentru a le revizui inainte de a le fuziona in branch-ul principal (main).

### Feedback si fuzionarea branch-ului:
Dupa primirea feedback-ului, am refactorizat codul si am fuzionat branch-ul refactoring-branch in main.

## Comenzi Git utilizate:

- `git init` – Initializarea repository-ului local.  
- `git add .` – Adaugarea fisierelor in staging.  
- `git commit -m "Adaugat codul initial"` – Crearea unui commit cu codul initial.  
- `git remote add origin <repository-url>` – Asocierea repository-ului local cu cel de pe GitHub.  
- `git push origin main` – Urcarea codului in branch-ul main.  
- `git branch -M main` – Setarea main ca branch principal.  
- `git checkout -b refactoring-branch` – Lucrez pe branch separat pentru refactorizare.

