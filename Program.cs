using System;

// char c = 'a';
// string dd = "aiai";
// short s = 32767;
// long n = 76765756756;

// sbyte sb = -100;
// ushort us = 10000;
// uint ui = 1100000;
// ulong ul = 12345678990;

// float f = 2f;
// double d = 2.5;

// object obj = null;
// string str2 = (string)obj;

// dynamic dy = 8;
// dy = "Olá, mundo!";

// var x = "7";

// int[] arr = new int[10];
// arr[0] = 4;
// arr[arr.Length -1] = 6;

// int nn = 4 * 2;

// string y = null;
// Console.WriteLine(y?.ToString() ?? "numero nulo");

// int i = 3;
// switch(i){
//     case 3:
//         Console.WriteLine(3);
//         goto case 5;
//     case 4:
//         Console.WriteLine(4);
//         break;
//     case 5:
//         Console.WriteLine("Bom dia");
//         break;
//     default:
//         Console.WriteLine("Não sei");
//         break;
// }

// int[] arr2 = new int[100];
// for (int ij = 0; ij < arr2.Length; ij++) {
//     arr2[ij] = 1;
// }

// foreach (int number in arr2) {
//     Console.WriteLine(number);
// }

// void mergeSort(int[] arr){
//     int e = arr.Length;
//     int[] arraux = new int[e];
//     mergeSortRec(arr, arraux, 0, e);
// }

// void mergeSortRec(int[] arr, int[] arraux, int s, int e){
//     if (e - s < 2) return;

//     int p = (s + e) / 2;
//     mergeSortRec(arr, arraux, s, p);
//     mergeSortRec(arr, arraux, p, e);
//     merge(arr, arraux, s, p, e);
// }

// void merge(
//     int[] arr,
//     int[] arraux,
//     int s, int p, int e)
// {
//     int i = s, j = p, k = s;
//     while (i < p && j < e){
//         if (arr[i] < arr[j]){
//             arraux[k] = arr[i];
//             i++;
//             k++;
//         } else {
//             arraux[k] = arr[j];
//             j++;
//             k++;
//         }
//     }

//     while (i < p){
//         arraux[k] = arr[i];
//         i++;
//         k++;
//     }

//     while (j < e){
//         arraux[k] = arr[j];
//         j++;
//         k++;
//     }

//     for (int t = s; t < e; t++){
//         arr[t] = arraux[t];
//     }
// }

byte[]? compress(byte[] arr){
    if(arr.Length % 2 != 0){
        return null;
    }

    byte[] compressedArr = new byte[arr.Length / 2];
    for(int i = 0; i < arr.Length / 2; i++){
        int bit1 = arr[i] >> 4;
        int bit2 = arr[i+1] >> 4;
        int compressedBit = (bit1 << 4) + bit2;
        compressedArr[i] = (byte)compressedBit;
    }

    return compressedArr;
}

byte[] decompress(byte[] arr){
    byte[] decompressedArr = new byte[arr.Length * 2];

    for(int i = 0; i < arr.Length; i++){
        byte bit1 = (byte)((arr[i] >> 4) << 4);
        byte bit2 = (byte)(arr[i] << 4);
        decompressedArr[i] = bit1;
        decompressedArr[i+1] = bit2;
    }
// 1 1 0 0 
    return decompressedArr;
}

void compressAndDecompress(byte[] bytes){
    var start = DateTime.Now;
    var compressed = compress(bytes);

    bytes = decompress(compressed);

    var end = DateTime.Now;
    Console.WriteLine($"Tempo total: {(end - start).TotalMilliseconds.ToString()} ms.");

}

byte[] arr = new byte[6220800];
compressAndDecompress(arr);