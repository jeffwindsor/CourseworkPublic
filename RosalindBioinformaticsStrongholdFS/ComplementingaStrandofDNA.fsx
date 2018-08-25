﻿#load "Collections.fs"
#load "Cellular.fs"
open Bioinformatics

let answer = 
    Nucleotides.Dna.lex >> Nucleotides.Dna.toReverseComplement

let input = "AATTTGCGAGGTAATCTCTTACTTCTATCCCGTCATAGTGGTTGTTTCAATATGACCTAATGTCTACGAAGTATATCGTGGGTAGACATGGGGCCACCATGCCGGCACATGTGAAGGAACGCTTCAACGGCGGTGTGTGCTGGCCGTCGCCTGATACGATCTGAGCCCCCTGGCAGACTCGTCAATGCTCTCTACAACTAAGCTCGTACATGGACTTTACTGAGGTACAAGTACCGATTACGTCGGCGCTTGGCCGAAATGGATGTCTATGGTGTCATCTGGAAGTATAGCCGACGGCGCATCAGCACAGCCGACTTGGACACCAAACAGTATGATGGGCCAGGAGTGTAGTGCCACAAGGGAAATAGGAGATTTATCTGCTCAGCAAGACCACGATTCGTGGTGTTGGAACACGTTGTGTACGTTAATACCGAAGCATGTCTGAGGCAATCATACTCGCTACCGGTGGGTAATGTTGGGTTCCTTCTAGCCACTTGTTTTGGGGCATACTCGGTAATGTGCAATACTCACCTTATCGCAGGCCTCGCCCTTAAGCGGCCATGATGGGATAGACTAACCCGTCCTATTGCAAGGAAAAGGGCCGCGACATAGGGAGCAGGATCTAAGAGCAGAGGCCATAACAAACTCTTCGTTAATGGTGGAGATTACGGGCGAACCGATCGCCCGTGAATGAGATGCTTGCGGGGGGAGACCTGTTCGAACTTCCCGTTATGGCACCTAGTGCAACGAGTTGCACCAGCTCTTTCAGCCAAAGTGAGGATGTACGTGCGAGATAGTCTGAGTCCCACGCTGTTAGGATGGTGGGGTGGGTGGTTGACCTCGCCTACGTCGACGTCTTTTGCTACCGGCAACTGCTATTCTACAATTTGAGCTATTTTTTATATATC"
//let expected = "GATATATAAAAAATAGCTCAAATTGTAGAATAGCAGTTGCCGGTAGCAAAAGACGTCGACGTAGGCGAGGTCAACCACCCACCCCACCATCCTAACAGCGTGGGACTCAGACTATCTCGCACGTACATCCTCACTTTGGCTGAAAGAGCTGGTGCAACTCGTTGCACTAGGTGCCATAACGGGAAGTTCGAACAGGTCTCCCCCCGCAAGCATCTCATTCACGGGCGATCGGTTCGCCCGTAATCTCCACCATTAACGAAGAGTTTGTTATGGCCTCTGCTCTTAGATCCTGCTCCCTATGTCGCGGCCCTTTTCCTTGCAATAGGACGGGTTAGTCTATCCCATCATGGCCGCTTAAGGGCGAGGCCTGCGATAAGGTGAGTATTGCACATTACCGAGTATGCCCCAAAACAAGTGGCTAGAAGGAACCCAACATTACCCACCGGTAGCGAGTATGATTGCCTCAGACATGCTTCGGTATTAACGTACACAACGTGTTCCAACACCACGAATCGTGGTCTTGCTGAGCAGATAAATCTCCTATTTCCCTTGTGGCACTACACTCCTGGCCCATCATACTGTTTGGTGTCCAAGTCGGCTGTGCTGATGCGCCGTCGGCTATACTTCCAGATGACACCATAGACATCCATTTCGGCCAAGCGCCGACGTAATCGGTACTTGTACCTCAGTAAAGTCCATGTACGAGCTTAGTTGTAGAGAGCATTGACGAGTCTGCCAGGGGGCTCAGATCGTATCAGGCGACGGCCAGCACACACCGCCGTTGAAGCGTTCCTTCACATGTGCCGGCATGGTGGCCCCATGTCTACCCACGATATACTTCGTAGACATTAGGTCATATTGAAACAACCACTATGACGGGATAGAAGTAAGAGATTACCTCGCAAATT"

answer input
|> Seq.printAsLine