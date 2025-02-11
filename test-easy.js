/**
 * @param {string} word
 * @return {boolean}
 */
var detectCapitalUse = function(word) {
    if (word.length < 1 || word.length > 100) return false; // Verifica o tamanho
    if (!/^[a-zA-Z]+$/.test(word)) return false; // Verifica se contém apenas letras inglesas
    
    return (
        word === word.toUpperCase() || // Todas as letras maiúsculas
        word === word.toLowerCase() || // Todas as letras minúsculas
        (word[0] === word[0].toUpperCase() && word.slice(1) === word.slice(1).toLowerCase()) // Apenas a primeira maiúscula
    );
};