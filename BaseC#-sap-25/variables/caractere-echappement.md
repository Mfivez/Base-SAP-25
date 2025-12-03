# Guide des Séquences d'Échappement en C#

## Introduction

Les **séquences d'échappement** sont des codes spéciaux qui commencent par un backslash `\` et permettent d'insérer des caractères spéciaux dans vos chaînes de caractères.

---

## Les Séquences d'Échappement Courantes

### `\a` - Bell (alert)

**Ce que ça fait :** Émet un son "bip" (alerte sonore)

**Explication :** "Bell" signifie cloche en anglais. Sur les vieux terminaux, ça faisait sonner une vraie cloche. Aujourd'hui, votre ordinateur émet simplement un bip.

```csharp
Console.WriteLine("Attention !\a");
// Vous entendez un petit bip
```

---

### `\b` - Backspace

**Ce que ça fait :** Recule d'un caractère (comme la touche retour arrière)

**Explication :** "Backspace" = espace arrière. Efface le caractère précédent.

```csharp
Console.WriteLine("Bonjou\br");
// Affiche : "Bonjor" (le 'u' est effacé)
```

---

### `\f` - Form Feed

**Ce que ça fait :** Saut de page (pour les imprimantes)

**Explication :** "Form feed" = avance le formulaire. Utilisé pour dire à l'imprimante de passer à la page suivante. Quasi obsolète aujourd'hui.

**Usage :** Rarement utilisé en programmation moderne

---

### `\n` - New Line

**Ce que ça fait :** Saut de ligne (va à la ligne suivante)

**Explication :** "New line" = nouvelle ligne. Équivalent à appuyer sur la touche Entrée.

```csharp
Console.WriteLine("Ligne 1\nLigne 2");
// Affiche :
// Ligne 1
// Ligne 2
```

**⭐ Une des plus utilisées !**

---

### `\r` - Carriage Return

**Ce que ça fait :** Retour au début de la ligne (sans descendre)

**Explication :** "Carriage return" = retour du chariot. Sur les machines à écrire, le chariot revenait au début de la ligne. Ramène le curseur au début de la ligne actuelle.

```csharp
Console.Write("12345\rABC");
// Affiche : "ABC45" (ABC écrase les 3 premiers caractères)
```

**Note importante :** Sur Windows, un saut de ligne complet s'écrit `\r\n` (les deux combinés).

---

### `\t` - Horizontal Tab

**Ce que ça fait :** Tabulation horizontale (comme la touche Tab)

**Explication :** "Horizontal tab" = tabulation horizontale. Ajoute des espaces pour aligner du texte.

```csharp
Console.WriteLine("Nom:\tJean\nAge:\t25");
// Affiche :
// Nom:    Jean
// Age:    25
```

**⭐ Très utile pour l'alignement !**

---

### `\v` - Vertical Tab

**Ce que ça fait :** Tabulation verticale (descend de quelques lignes)

**Explication :** "Vertical tab" = tabulation verticale. Version verticale de `\t`.

**Usage :** Très rarement utilisé en pratique

---

## Les Guillemets et Caractères Spéciaux

### `\'` - Single Quotation Mark

**Ce que ça fait :** Affiche une apostrophe/guillemet simple `'`

**Explication :** Permet d'insérer une apostrophe dans un caractère délimité par des apostrophes.

```csharp
char lettre = '\'';  // Le caractère apostrophe
string texte = "C'est cool";  // Ici pas besoin de \' car on utilise des "
```

---

### `\"` - Double Quotation Mark

**Ce que ça fait :** Affiche un guillemet double `"`

**Explication :** Permet d'insérer un guillemet dans une chaîne délimitée par des guillemets.

```csharp
string phrase = "Il a dit \"Bonjour\"";
// Affiche : Il a dit "Bonjour"
```

**⭐ Très courante !**

---

### `\\` - Backslash

**Ce que ça fait :** Affiche un vrai backslash `\`

**Explication :** Comme `\` est le caractère d'échappement, pour en afficher un réel, vous devez le doubler.

```csharp
string chemin = "C:\\Dossier\\Fichier.txt";
// Affiche : C:\Dossier\Fichier.txt
```

**⭐ Indispensable pour les chemins de fichiers Windows !**

---

### `\?` - Literal Question Mark

**Ce que ça fait :** Affiche un point d'interrogation `?`

**Explication :** "Literal" = littéral (tel quel). En C/C++, `??` pouvait causer des problèmes (trigraphes). En C#, vous pouvez simplement écrire `?` directement.

```csharp
string question = "Pourquoi?";  // Pas besoin de \? en C#
```

---

## Les Notations Numériques

### `\ooo` - ASCII Character in Octal Notation

**Ce que ça fait :** Représente un caractère par son code en **octal** (base 8)

**Termes techniques :**
- **ASCII** : Système de numérotation des caractères (A=65, B=66, etc.)
- **Octal** : Système de numération en base 8 (chiffres de 0 à 7)
- **ooo** : Jusqu'à 3 chiffres octaux

```csharp
Console.WriteLine("\101");  
// \101 en octal = 65 en décimal = 'A' en ASCII
// Affiche : A
```

**Utilisation :** Rare en pratique moderne

---

### `\xhh` - ASCII Character in Hexadecimal Notation

**Ce que ça fait :** Représente un caractère par son code en **hexadécimal** (base 16)

**Termes techniques :**
- **Hexadécimal** : Base 16 (chiffres 0-9 puis lettres A-F)
- **hh** : Deux chiffres hexadécimaux

```csharp
Console.WriteLine("\x41");  
// \x41 en hexa = 65 en décimal = 'A' en ASCII
// Affiche : A

Console.WriteLine("\x48\x65\x6C\x6C\x6F");
// Affiche : Hello
```

---

### `\xhhhh` - Unicode Character in Hexadecimal Notation

**Ce que ça fait :** Représente un caractère **Unicode** avec 4 chiffres hexadécimaux

**Termes techniques :**
- **Unicode** : Système incluant TOUS les caractères du monde (émojis, chinois, arabe, etc.)
- **Wide-character** : Caractère "large" (prend plus de place en mémoire)
- **hhhh** : Quatre chiffres hexadécimaux

```csharp
char caractere = '\x4e00';  // 一 (le chiffre "un" en chinois)
string texte = "Le caractère chinois pour un est \x4e00";
// Affiche : Le caractère chinois pour un est 一
```

**Alternative en C# :** Vous pouvez aussi utiliser `\u` suivi de 4 chiffres hexa :

```csharp
char coeur = '\u2764';  // ❤
Console.WriteLine($"J'adore le C# {coeur}");
```

---

## Tableau Récapitulatif

| Séquence | Nom | Description | Fréquence d'usage |
|----------|-----|-------------|-------------------|
| `\a` | Bell | Bip sonore | Rare |
| `\b` | Backspace | Efface caractère précédent | Rare |
| `\f` | Form Feed | Saut de page | Obsolète |
| `\n` | New Line | Saut de ligne | ⭐⭐⭐ Très fréquent |
| `\r` | Carriage Return | Retour début de ligne | Moyen |
| `\t` | Tab | Tabulation | ⭐⭐⭐ Très fréquent |
| `\v` | Vertical Tab | Tab verticale | Rare |
| `\'` | Apostrophe | Guillemet simple | Moyen |
| `\"` | Guillemet | Guillemet double | ⭐⭐⭐ Très fréquent |
| `\\` | Backslash | Antislash | ⭐⭐⭐ Très fréquent |
| `\?` | Point d'interrogation | ? littéral | Rare (inutile en C#) |
| `\ooo` | Code octal | Caractère ASCII | Rare |
| `\xhh` | Code hexa | Caractère ASCII | Occasionnel |
| `\xhhhh` | Code Unicode | Caractère Unicode | Occasionnel |

---

## Les Plus Importantes à Retenir

Pour débuter, concentrez-vous sur ces 4 séquences :

1. **`\n`** - Saut de ligne
2. **`\t`** - Tabulation
3. **`\"`** - Guillemets dans une chaîne
4. **`\\`** - Backslash (chemins Windows)

---

## Astuce : Les Chaînes Verbatim

En C#, vous pouvez aussi utiliser le `@` devant une chaîne pour éviter les échappements :

```csharp
// Sans verbatim (avec échappements)
string chemin1 = "C:\\Users\\Jean\\Documents\\fichier.txt";

// Avec verbatim (plus lisible)
string chemin2 = @"C:\Users\Jean\Documents\fichier.txt";

// Pour les guillemets dans une chaîne verbatim, doublez-les
string phrase = @"Il a dit ""Bonjour""";
```

---

## Ressources Officielles

📚 [Documentation Microsoft - Escape Sequences](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/escape-sequences)

---

## Conclusion

Les séquences d'échappement sont essentielles pour manipuler du texte en C#. Commencez par maîtriser `\n`, `\t`, `\"` et `\\`, puis explorez les autres au besoin !

**Happy coding! 🚀**