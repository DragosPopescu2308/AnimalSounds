# Animal Sounds

**Nume student:** Popescu Dragos

## Implementarea problemei AnimalSounds

Pentru implementarea acestei probleme am urmat pașii:

1. **Crearea aplicației consola simplă:**
   - Inițial am creat o aplicație console simplă care nu respecta principiile OOP, pentru a putea lucra la ea și pentru a putea face refactorizare pe aceasta.

2. **Crearea unui repository pe GitHub:**
   - Am creat un repository pe GitHub pentru a încarca proiectul și pentru a-l gestiona.

3. **Inițializarea repository-ului local:**
   - În terminalul deschis în Visual Studio, am mers la fișierul în care aveam proiectul și am inițializat un repository folosind comanda `git init`.

4. **Adăugarea codului inițial în staging:**
   - Am adăugat codul creat inițial în staging pentru a-l pregăti pentru commit.

5. **Crearea primului commit cu varianta inițială de cod:**
   - Am creat primul commit cu varianta inițială de cod folosind comanda `git commit -m "Adăugat codul inițial"`.

6. **Asocierea repository-ului local cu cel de pe GitHub:**
   - Am asociat repository-ul local cu cel de pe GitHub, folosind comanda:
     ```bash
     git remote add origin <repository-url>
     ```

7. **Urcarea codului în branch-ul `main`:**
   - Am urcat codul în branch-ul principal folosind comanda:
     ```bash
     git branch -M main
     git push origin main
     ```

8. **Crearea unui branch separat pentru refactorizare:**
   - Am lucrat pe un branch separat pentru refactorizarea codului și implementarea principiilor OOP.

9. **Refactorizarea codului aplicând principii OOP:**
   - **Crearea interfeței `IAnimal`:** 
     - Am creat o interfață `IAnimal`, care este implementată de fiecare clasă de animal.
   
   - **Crearea de clase separate pentru fiecare animal:**
     - Am creat clase separate pentru fiecare animal (ex: `Cow`, `Dog`, `Cat`), fiecare implementând interfața `IAnimal`.

   - **Modificarea `Program.cs` pentru a folosi lista de obiecte OOP:**
     - În `Program.cs`, am folosit o listă de obiecte de tipul `IAnimal` și am apelat metoda `MakeSound()` pentru fiecare obiect.

10. **Salvarea modificărilor și urcarea pe GitHub:**
    - După refactorizare, am salvat modificările și le-am trimis pe GitHub.

11. **Schimbarea branch-ului pe GitHub:**
    - Am schimbat branch-ul pe GitHub pentru a lucra pe varianta refactorizată (ex: `refactoring-branch`), iar în `main` am păstrat varianta inițială.

12. **Crearea unui Pull Request:**
    - Am creat un Pull Request pentru a propune modificările și pentru a le revizui înainte de a le fuziona în branch-ul principal (`main`).

13. **Feedback și fuzionarea branch-ului:**
    - După primirea feedback-ului, am refactorizat codul (dacă a fost necesar) și am fuzionat branch-ul `refactoring-branch` în `main`.

---

**Comenzi Git utilizate:**

- `git init` – Inițializarea repository-ului local.
- `git add .` – Adăugarea fișierelor în staging.
- `git commit -m "Adăugat codul inițial"` – Crearea unui commit cu codul inițial.
- `git remote add origin <repository-url>` – Asocierea repository-ului local cu cel de pe GitHub.
- `git push origin main` – Urcarea codului în branch-ul `main`.
- `git branch -M main` – Setarea `main` ca branch principal.
- `git checkout -b refactoring-branch` - Lucrez pe branch separat pentru refactorizare

