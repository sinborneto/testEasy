using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution {
    public bool DetectCapitalUse(string word) {
        if (string.IsNullOrEmpty(word) || word.Length < 1 || word.Length > 100) return false; // Verifica o tamanho
        if (!Regex.IsMatch(word, "^[a-zA-Z]+$")) return false; // Verifica se contém apenas letras inglesas

        return word.All(char.IsUpper) ||  // Caso 1: Todas as letras maiúsculas
               word.All(char.IsLower) ||  // Caso 2: Todas as letras minúsculas
               (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower)); // Caso 3: Apenas a primeira maiúscula
    }
}