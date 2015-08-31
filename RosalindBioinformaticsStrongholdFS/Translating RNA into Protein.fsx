﻿#load "Fasta.fs"
#load "Seq.fs"
#load "Proteins.fs"
#load "Genes.fs"
#load "Transcription.fs"

let find
let translateRnaIntoProtein filepathToRna =    
    filepathToRna
    |> Fasta.ReadUsing (
        Genes.Rna.lex 
        >> Transcription.Scenarios)
    |> Fasta.AsValues

    //TODO: for each scenario, for each M..Stop produce a result 

translateRnaIntoProtein "Translating RNA into Protein.txt"
|> Seq.map (fun s -> Seq.toString s)
|> Seq.print


// proteinSeq AUGGCGAUUAUUCACGCUGCCGUUCUGACCAAGUCGCUGGGUGACUUGAGCGCGAUCCCCCACCGCCGCCGACCCCAUUAUAAAGAUGUGACCACGAUUUUGAACGAUAAGUAUGAUCCUAACCCUCCACUUUGUAACGUAUGGCACCAAGGACUGUCGGGGCCGUUAAGCACGGAUAAGUCUCAAUGGGACUCGAGAGUCCGCGGCUGGGGGAUGCCCCCCGCAUAUCAGUCAGCUGGAAGUGACCGUUCCGAUGGGAACCUCUGGCAUGACGCCGCUGCGCGCGGCGGGGAUCCUACACGGGUAAAAGAUGCGGGACAGCCAGUUAGUAACAUUUUGCCGAACAGAAAAUGUCUGCUCAAGAAAUGUGUACCCACUAACCUUGCUUAUCGUUGGCCGCAAGUCCACGUCAUUUCUUUAUCGUCGACCAAUGUGGGUGCAGCGCCCUACGCUCUUUCUACACUGGGCAGGUGGGCACUCCCUAUGCGAACAGGACAAACAAUGAGAAGACAGGAAAUACUCGGUGUGAAGGUGCAACCAGAGGCGAGAACGUUCGCAAUAUAUCGGAAGCGAUCAAUAAAGAAUGUGCAAAAGUGCAACGUGCGUUCCUUAUUACGCAACCUACUUGCAUAUCUGGUCCGUGAACGACUGGUGCCGCUUGGGGCGCUUCGGGACCAUUUGCCUCUUCUUCAUCGCGGCCGGCACCUCCGGCUGGUAUCGACGAAAAUUCUAAAUAUCACUCGCGGGAUGGUCAAGCGUUUCAUGUUUGUCAACCCCACAGCGCGACUUGAGAUAGCGCCGGAAAUGGUAGCGGGUACCUUCUUAUUUUCCUAUCCAGGAAGAUCAUGUUGUUCCUGCCCAAUGCUGAUGAAGAGUUCGACAGGAUUAGCCAUGUGUAUGUGUCCUCUGACCAUGCAAGAAAGGUAUGCGUCCGACUGUAGCUCUUGCCGUGUCGGUAAUGCGCUCCGACCGCCGAUUAAGAAACACUCCCGCUGUGUGUAUAGGUCCCAAUUUUGCCAUUAUUGCGUCGUCGAGAUUUCUCAUGAUAUUGCCAUGGAAAGCACCGAUUUACCACCGUUGACGAAGAGGUACGAGCGUGCUCCCAUCUUACGCAUAUUAAUCCAGUCCUUUUGUUGUUUAUACAGACUAUGUCGACCAUCACGCUCUGCACGUUUCGUAGGGCUCAGUGAUAAGAUAUUUACAAAUGUCCCACCGUGUAACCAGGCACCUUCUGUGUAUAUAAAUGGCGGGGCCUCCAUCCUCGUCGCUCACUACCCUAGACACCCGCUCGUCCGAUGGAGGAUUACCCUGUUGGCGAAGACCUCCUGCUGUAAUGGCCGGAUAAAGACUGACUUAGGGGAUAGAACUCGAACGAUGUCCUUGGAUAGAUCAGGAAAAGCACACAGUCAUAAGAUAAGAGAGAAUGUACGCUCGCAAGGGACGUUCCUCAAAGGGUUCCAAAUAGCGGACGGAAAAGGUGGAGCGGUCGCCGUGCCGGGACGUUGGUCGCACCUUCAUUAUAUGGGGGUGUACCUCCAUCAUACCCUGACAGCCAAUCGGGUCCUGUCGUUAGCUACCCCUCGAACACGAUGUUCUGACCUUAUCCAGGCGUCAUGGUGCAGGGAUGAGUCCAAGACGUCCUCAAGUUCCCCCCGUAGAGGAGGAACGCGCAACAGAGGUAUGGGGGCGUUUCAUCUUACGCCGCGACUGGGGGUCAGCUUCUGUAGUACAAGAUCGCCUCGGUUUCCGGAAGAUGGAAGUUGGUUGGCUGGCAGCCGUGAGGUGCACGAUGGCACGGGUCGAGUGUCCCAGUACUGGGUCCGGCUUUUGCGUACUUCCCGAGAUCAGAGGGGGAAAACCUUUGAAUGGGACCCUUCUUACUGUAUGGUUAGAUUAGGAGCGAUAGAGUCGAAGUUGCAGACGAACCUCGCGGUUAGCGACUCCGAAUGUUCCGCUUUAUUGACGCACACAGUCACGGUAUAUGGAUCUCGGACAUCGCGAGAUGUCAACCGCUUAGUCAGCGUGAUGCCCUACUACAAAUCAGGUAUGGGUUUGACAACUUCACAUGUUUAUGGGCCUUCGUACAUCAGGCUGACGAGAUCGAGACUUUCUAUCGUGGCCUCAUCUGGUAGUACGAUGGAAUAUUCCGCUCCACUGAAGAAACUAAAAUCGAGAUUACAACGGCGUACUAUCGUCUGGAUAUUAAAACAGCCUUCACUGCUGACAUGCGUCCGGCCGUAUCUGUUAUUAACCUCCUUAGAAACGUUUUUUGAGACCCUACCAUGUUCGCAACCCACGCAUGCCUAUCUAAUGUGUUUUCUAGGCGACGGCGGUGUUUUCUGGCUUGUAGUACUGGGGGACCCCGCGCCCCCCCUGCUCCAGAUAAGGUUCCUCGCAAGAUGGCAGUUUAAGAGACUUAGGCUUGUAAGCAUAGUUCUUUUCAGUACGGCUAAUGAUGGGACAAACCCUAUCUAUGACGUAUCCAGCGGUGUGCUGCAUAUCUGUACAAGGAAUGCGUGUAGCCUCACAGCAUAUUUCGUGCCGUUUGGGGCAUAUAAUUAUAUAGCAGACAAAGCAGAUUGCCAGAGGAGAGCUGAGCACCAUGAUUGUGCCACGCAGGCACUUUUCCGCGGGCCCAGUUUUUGGAUGCACAUCGUCAAAAUUGGCAAGAUUAAAAUAGCGCACACUGGUGCUUGGAGAUGGAUUCACCCGUUCUUAGACUCGUCCAUAACAAGUAGUAUUAAGCUAGAUGUCGUUGUCCUCCGCAUUAUAUGUUGCCCGACUUACCCGGCGGAGCGAUACUUUCGGAAGGAAGGCUCGUGGCGCCUGCUACGUAUAGCGGACGGUCAACGAGAUUCUAUACCGACACUCCGAGGCCUUAACUUAAUGUGCGCAGCCCGGUUGUCUACAAAUGCGGGUGUCGCGCAUUCCCGACCUAGCUGGAUUAGGCGCUCUACCAACGAGGGUUUGCAGAUUAGAUGGCGCAUGCUAGCGAGUAGGCAGUUCUCAGUGAGGAAGCGGCGCCUUUGGACGAGGGAUUAUAAAUUCGUUUGGGAUUUGCGUAUAUUAUGCUAUACGCGCCCAGACCCUUACAUCGACCGGAAAAAGUUACACACGUCAUCAGGGAGUGGGCCCCAGACACCGACAUUAACGAUAGAACUAAAUCCGCGCACCUCAGGCGCGGUACAUCGGGGGCGGCGGGAAAUCGUACAGCCUAGGGCGCACGACCCGGCAGCUGUGGUGUUGAAGCGAGACAACUGUUCGCGGUUAACCCGGUCGAUCCGACCCUUUAUGGUGGCGAUAGUCUCGUGGGGCGGAGCUGUACGAUUCAAUAGAGUCUUAUUCCAGGGUCCAACGUCGACCGCACUUCGUUGGCGCCCCAUCGACCUCGCUAAUAAGGGACAAGCCGGAACUCGGUUGCAGAAAUUCAUCACACGCUUCGAGGUGAUAAGGUGUUAUUGGCACGGUUUCCACCCCAUGAAGAAAUUCCUCCGAUCUGGUUCCUUGCCGUUGCCCCUGUCAACUCAGUGCGCAGGCUCCGUGGGUGUGGGCUGGGGUAGUUAUCCGAGGACUGACCCUAUGGGGCAGAAGUUUGAUAAGGCGGCCGAGUUCUUUUACAUAUCUGUCUUAUUCCCAAGAGGUCUGAAGACGCGUGGUCUGUGCAUCAAACGGAAACUCCUCGUGGUCCCUAAUUCCGUCACUUUUAAUAUUGUCCCUUCGUUAGACUAUAGGUAUGCUAGUAGUCAUAGUUUAGGUCUGAUAGAUAACGCGCGCUCCAAACGUUCAACCCUGUGUAGGGGACAGCCGUACCAUCAGACUGCAAAAAACCUCCCUAAGCGUAAUGGGGUAGAUAGUCAACUUCGCAUUCCCUAUAAUUCAGGACUUGCUUACCGUGGUUAUGUGCGCGUUGUUAAGCAGAAAGUAAGUCAUAGCACCCUUGAGAUUCAAUUUGGGCUCCAACGACUUCGCACAGAACUACCUCCUCAAGACGUCCCCCGCAGGGUUUAUCGGGGCUCCUCUGGUUCGACAAUACGUUAUUUAGCCUCAGUCCGGCACACCCACGCCUUGCCUCUUCGCAUGUCUUGCGAAUACUUUGUACCGAGCCCACAGUUUGUCGCUGCACACAUGCGCGACUGGGGCGAGACUUGUGCGAUCGGCAUCCGGAGGUACAUACAUUCUGAACCCCGCGUACGUUACCGGAAACGUGAGGAGCACGGAGGUAUGCUGCGGAGAUACGGAAGUUCAACAGGGAGUAUCUGGCAGAACCCUCCACUGUUAGCCACUGGACCGGCUGUGUUCAGGCGUAUGAACGUGAGCCCGCGCCUUAGGGUGAUCUUCGAAUACCGUACUCGAUCGCGUAUGGGUCAGGAUCCUAGAUGGGCAGAAAAGGCUGGUUGUAAAUUUUCAAACGGCGAUAUGCAUGAUCAAUUUGGAUACCGCGCCUACCUUAGACUUCUUACCUCUCCAAUUCGUGUGCUACGUGGAACGCUAGCACGUCAGGUACGAAUAGGGAUGCUUGACAUAUUAGGCUUCACGCCAGCUGAAUAUAAUAACUCCUCUCCGGACGCUCAACUAUGCCUAGCCUGCGCGUCGCGCGGCUUUCCCGUCCUAAUCUUAGACAAGGCUCAGUCGUGGCAGUAUAGCAGUUGUUGCCAAACAAUCGCAAGAGAGGCUGUGGACAGUUUCGCGCGUGAGUCGAGUCGAAGUAUACGGUGGCCCGAAAUAGCGCUGAGGAACCCUCAUAGAGGAACGUGGCGGUUCAAUGCGCAAGGUACCCCUUCUCGCCCGUUCAUCGGGCUGUCUGCGUCCAGGCGCCACAUAAUGUCCCUUCAAGUAACCAAUUUGCUCGAUCUGGAAAGGUGGACCCAGAAUUAUAGCGCUCGAUACACGCUGAGGAUAAUACUGUCUAUACACAUGAACAGUUUACCGCCUACGACCUCAAUUACUGGCGGUCAUCAACGUGCAAAAAUUGGGCGGGCGCCAGUCUCUGGAGAUCCUGCAAAUGGUGUGUGGGUGGCGAUUUUAAGAAGUGACCUAAGGUUGGAUCAGGGAGAAGUUUGUUACAUAGAAUGGUGUAGCCCAGUCGCCUUACUAGUGUUUCCGAAGACUCUUAGUGUCCUGCGUAAGUUCUUUUCAGCGUUUGGUGACAGGGGUUGCCAGUCCUCUUGCGACGGAAUCCUUGUGCGUUGGGGGAGAGGGUGUCGGCCAGCCAUGCAAGUAAUCUCCUCCCUCAAUCGGCUUGCCCUGAACAUUGGACUAUCUCGCCUUAAUAGUUGGUCAGAGCUCGACUCUUUUGAUGUGGAUACUCGAUGGAUAGUUUAUCUAAGGGUGUGCUGCAUAAGUGACGGUCCCGCCUUAUACUCCAUCUACAGCCUGAGCCCCCACACAAAGACGCCACCGAGAAAGCUGUACCACCGGUCCACGCUCCUUUCGGUCCUGACACCAACGUGGGCUGAGCAGUCCAGGCUCCUCCCCAAUCUAAAGCGCGGCCCUUGUGUUUGCCAGCAGUCUGGGGUACUGCAUUCUUUGCAGCAGUUACACCCUCAAUUAUCUGCAAAGCCUUUCCGUACGAAGGGCCUCGCACCUGGGUCGCGCCCUACCGUACGUCCACCCCUCGCCUGCCCCGCCACCAACUCAAAGGACCGUCAGUUUCUUUCACCUUCCAGUCACAGUGGGAUUAUGCCAUUCUAUCCUAUACCCAAACAUUGCGAGCCGUGGGUGGACACUUCUCUCAAAUCUAGGUGUGGUUGCCGCACCGAACAAUUAAGAUCCCUAAAUGUUACCCACACAGAAGCUAAUGGAGCCAGUGGCCAUCUACCGGGUGCCGCGCUUGCCGAUUCCCUAGUUCACGGAGCCUCCCUGCGUCUGAAGGACUGCCCUCCCCCGCCAGAAGGGAGCGAUGUGUGUAUGGCGUGGGGAUACCGACAGCCGCAGAUGAGCCAGAACCAACGACCUCUUGAGCCUCGCUUACGUGCUCACGCUUGGGGAGCGUACAGUUGUAAUGACAUACGCCGAAGACUCCCCCCUCUAGAAUCGGCAGUGCGCAGCCACCUAGUAAGAGUUUGCGAUUUGGUCCCCGCGUGCCGCUGGCAUGGGACCGGAGUACCUAGCUUUCAUGUUGGAGGCGUUCCGUCAGCAGGAUCCCCUGUCAGGUACAGCUACGCGCCCCCAAAUCCUGCUGCGGGACUCUCAGAUUCGGGUCACGUGAUUGCGAGAAAGGAUCUGACACCCACGUGGGACUGGAGCACAAGGGUCCAGAUAAGACGCAAUCCUGAUUCGUGGACGUGGUCAGCUGGCGUCGGCAUACCCGUGAUUCCGAAAGCACAACACUUUGAACGGAUCACCGGGGCGUUGCAGACUACGGUCAGGACAAGGGGAACUGGGGAUCCACCACUUCCUCGCAUCUGCAGCCUGCGUAAUAAUGCACAGAAGUUGAUUGCGCUGGCUGCUACCUAUAUCGCGUGUCGGAUUAACAACUUCCAUAUGUGCGGCAACCUUGCGCGUGAGAGAAAAGACCUCCCGCAGCGCUUGUAUUAUCCAUAUAUUCUAAGAGAUGCAUACUGGAUAUUAAGGGGUGUCCUCCUUCCGUUGACGGACCCUGACCUGCUUUACAGCUUAAGUAGCAAGAAGUGCUUGACGUGUCUCAGCAGCAAAGUGGCACUGCUCUAUUACAAAGAGGCUCGUUUUGUCGACCUCGCGCCAACUCCAGCUCCCUUAGAGUCUACAAUUACUCGGUAUUGCUUCGGUCCGGCACCCCAAAGGUAUAUUUACCGGCCUAAAUAUCGCCGCCCAAAUGUAGUUACGUCAUCGCUUUCCGAGCCUUUGGUCCUGAUGAUCAACGGUGCAGGCCAGACGCUAUGUCCAAAGAUGGGAGCCCUGGCUCUUGAAAGCGAAGAGUCACGAUUUGCGGAAUGUUCUUUUCAUCGACUGCCCAGGCCUGGAGUCGUUAAUGUAUCCCACACUAUAUGGACAAAGAAACUGAGGUCAUCACGGUUCCAAAUAGGCAUUCUAAACGUGUGCUGCUCUUCGAAAGACCUAUUUGACUAUAAACUUCCCGCUAGUCUACCGGUUCACCUAAACAUCCCUAGUUUUCUGAAGAGGCUGAAAACUUUAAGUAGGGCGACACUCCUGUUCCGCCGUGUGAUAGGACUCGGUAGACAGAGGCUUAAUCCUUUCUCUCUUAUCAAUCUUCACUCCGAGUCUUUCCAUUUCAAAAGCCAUCAGUGCUCGGCUACGGUAGAGUCUCGAAGGGUUCGCAUCCAUACAGCAGCCUUCAUAGUUACUAAUGUUUGGCAAGUGACAGGACCACACAUUGGGUUUUAUCUAGUACCUGCAGUGUCCAACGUGGCUCGUAGUCUAUAUACUGCACUUCUUGAGUUAUCUCCACAAGGCCCGUCAAUUCGUCCAUACCGGUCGGCCGAGACACAUCCUUUAGACCUAAUCAGGGCCGUAACUUACCGCCUUAGGAUAAGCCGAGCUGGUGUCGAGCCAAGCAAAAUUUUACCACGUCUUAACAUACAACUAGUACGGGCCUCCGCCACUAAAGAGUAUCCGGGAUCGGAGCGUGGCUUGGUGGCAGCCAUCUGCUCCCCGGGGCGAGAAGCUUCGGUAAUAUACUAUCUUGGGCAGGAUAGUCCAUUUGUUGCGUUAUGCGAUCAUCCAGCGCUAUCUGUGUGCCGGCGCACUGGUGCUAAAAACGAGAGUAUUCUCCAACUCUGUCAACCGACACUGGGUCGUAGUUCAUAUGGUCAUGUUAACAGUCACCGCUCCGGACGAUCUGCAGUUGUAGUAGCGCGGAGACAUUAUGUACUCGAACACUGCCGAAAGUCGCCUCCUCCGCGUCAUUCCCUGCGACAUCUCACCAGGAAGGGUCCUCAAUCGAUUAAAUUAUCUUCCCUGGCCCCACGAGAGCAGUCCUGUCGGCAACUGACAGCAACCCAUCGAGUAGCCCAAGAUUUACAUAACGCCGCGUUAGGAGUGCUAAGACUUCUUGGCCUAGAACCCGGGUUAUUCGUUACCCACGAUGGUGAUGGCGAUAGCCGCAGAAUAAAUGCAAAUUCCGGCGUCGUCCGGGUCCUUGCUGAGUUCGCCCCGCGAAUGAUUAUGCGAAGAGCUGACGUUAAUAGAAACCCCUAUCUUAAUAGUCUCGACGAGCGUUGUCCCUCGGAGAGUGCCGAGCGCUUUUUCAGCCAUGGACCGAUAUCCUGUCAAGGCCGUUACUGGUGGGCCAGACGUUGUUCGUGCCGCACGACACGACAGUGGCGCCAUCGUGUACAAAGAACUCAAUUCGUCGUAAUUGUGUGCUGCCGACAGGCACACCGAGACCGACCAGAUGAGUCCGCAGAGGAACGCACUAACAAAGGGGAUCUAGGAGACCAUUCACUACUCCUACUCGCGGUUCUCGGAAACGAUCCUCACACCCAAGUGUUAACUCGGUUUGAAGCCAUCCGGGCGAGAAGCUGGGCUAGCGCUCGCCUGGCUAGCAUUUUAGUCGCUUGUACUCAUUCAGUCGCGAAGGCUAGAACCUUGGUGUCCCAUAUCGCACUUGAGCAACCGGGGGAGCCGUUCGCUAAUCCCGUAUGUUUUGUAUACCACACCGUGUUGUGUGGCGAAUUUGGUUCUCUUAGAAAAUGUACUACCAACGCUUCGCUAAAGCCCUGGCGCCUCCGAAGCGUUUUAAAGACGCUUGAGGAAUUAACGCUAUACUACAGUUCAACAGUAUCCGUUGAUCUUUUAGUGUGGCACCGAACAAUUGGGUUAGAUAACUCUGGAGGUAGGGUCUGGAAGUUCUACCAGCAUAAUAAGCUCCCGAGGGGUGUAACUUUAGUGUUGCCCUGUUCCGCAGCAUCAGACAAUGUGUGCUCCCUGUCGCAGUCCGCUUGCGUAAAAAUAUCUUUUCCCCUUAACCCUCAGGGGUUGUGUAGGAUGCAGCGGUAUACGAAAAAAAGGGUAAUGUGGCGUGGUUCAGACGAGGGACAGAGGAUCGAAAGUCUAUCAAUGACCGAUAGCAUUAUAAGCCCCAUUAUCAGCAAGGCGGGCGUUCGCGUCAGAGCCGCUAGGGAGCCUGGUCCAAUGCGCCUGGUAUGGGACGUAUCCUGCAGCGGUACGCGGCGCUGGCGUACCCGACGCAGGACCCGUAUGAAAAAUAACUUUGCAGCGUCACGUCUGCCGACAACCCCUGAAGGACAAUAUUCCCCAGGAAUGCGGUCUCAUAUUCCGGAUGCCCCUGUGAGACGGGCAGUAUUAGCAUCUUCCAACCGGGCUUCCAUGGCGCAUAUGCUAGGCUCUCGCGGCGUUCGCGGUAGAUGUCAAUUCUGCAAAAAUAGGAGCCGGGAGGCAAUAGAGUUUAGACGACGUCCGAUGUCGGUAGGGAAGCCGGGUUCCCCUAAAGCUGAGGCGGUAAGUGCGGUUGGUGACCUCGGCUACGUAGCGAUCAACCGAGAUCAUCUGCAGGUAGGGCUAACGCGCAUAAUUUACCAACGGUUGCAAGCAAUUUUCGUGCCUUUCGUUACGAGCAGUACCCACACUCAUCCUUGGCAAUGUUGGGAUACUAUUCUAGAGCCUCAUACUAGUGCGUUGGCCGCUAUAUCCUAUGCGGGUAAUGGCAAGCCCUGUUGGCAGCUAACUACAUUGCACCAACUUGUGGCGGAAGGGUUAGACUCCUUAAGGUCUGAGAUAUACUACCAGGCUACGUACCCUACCAAAGAUCGGAACUCAUUACAAAUAAGUAGCCGUCUCCCCGUUUUAGUGCAGGAUGCGAUGAAUGGUGCUUUUUUGCUCCUUCGGUGUACAGCGAGAAUCUGCGCGGUAAGACCAGAUUGCCACACCUGCCACAUCGAUUAUGCAUUCCGCUUGAGGCUAGGAGGUGAUCCUCUUCGAAACCUCUACGCUUGGCUGGGAGCAGGCUAA
//  = MAIIHAAVLTKSLGDLSAIPHRRRPHYKDVTTILNDKYDPNPPLCNVWHQGLSGPLSTDKSQWDSRVRGWGMPPAYQSAGSDRSDGNLWHDAAARGGDPTRVKDAGQPVSNILPNRKCLLKKCVPTNLAYRWPQVHVISLSSTNVGAAPYALSTLGRWALPMRTGQTMRRQEILGVKVQPEARTFAIYRKRSIKNVQKCNVRSLLRNLLAYLVRERLVPLGALRDHLPLLHRGRHLRLVSTKILNITRGMVKRFMFVNPTARLEIAPEMVAGTFLFSYPGRSCCSCPMLMKSSTGLAMCMCPLTMQERYASDCSSCRVGNALRPPIKKHSRCVYRSQFCHYCVVEISHDIAMESTDLPPLTKRYERAPILRILIQSFCCLYRLCRPSRSARFVGLSDKIFTNVPPCNQAPSVYINGGASILVAHYPRHPLVRWRITLLAKTSCCNGRIKTDLGDRTRTMSLDRSGKAHSHKIRENVRSQGTFLKGFQIADGKGGAVAVPGRWSHLHYMGVYLHHTLTANRVLSLATPRTRCSDLIQASWCRDESKTSSSSPRRGGTRNRGMGAFHLTPRLGVSFCSTRSPRFPEDGSWLAGSREVHDGTGRVSQYWVRLLRTSRDQRGKTFEWDPSYCMVRLGAIESKLQTNLAVSDSECSALLTHTVTVYGSRTSRDVNRLVSVMPYYKSGMGLTTSHVYGPSYIRLTRSRLSIVASSGSTMEYSAPLKKLKSRLQRRTIVWILKQPSLLTCVRPYLLLTSLETFFETLPCSQPTHAYLMCFLGDGGVFWLVVLGDPAPPLLQIRFLARWQFKRLRLVSIVLFSTANDGTNPIYDVSSGVLHICTRNACSLTAYFVPFGAYNYIADKADCQRRAEHHDCATQALFRGPSFWMHIVKIGKIKIAHTGAWRWIHPFLDSSITSSIKLDVVVLRIICCPTYPAERYFRKEGSWRLLRIADGQRDSIPTLRGLNLMCAARLSTNAGVAHSRPSWIRRSTNEGLQIRWRMLASRQFSVRKRRLWTRDYKFVWDLRILCYTRPDPYIDRKKLHTSSGSGPQTPTLTIELNPRTSGAVHRGRREIVQPRAHDPAAVVLKRDNCSRLTRSIRPFMVAIVSWGGAVRFNRVLFQGPTSTALRWRPIDLANKGQAGTRLQKFITRFEVIRCYWHGFHPMKKFLRSGSLPLPLSTQCAGSVGVGWGSYPRTDPMGQKFDKAAEFFYISVLFPRGLKTRGLCIKRKLLVVPNSVTFNIVPSLDYRYASSHSLGLIDNARSKRSTLCRGQPYHQTAKNLPKRNGVDSQLRIPYNSGLAYRGYVRVVKQKVSHSTLEIQFGLQRLRTELPPQDVPRRVYRGSSGSTIRYLASVRHTHALPLRMSCEYFVPSPQFVAAHMRDWGETCAIGIRRYIHSEPRVRYRKREEHGGMLRRYGSSTGSIWQNPPLLATGPAVFRRMNVSPRLRVIFEYRTRSRMGQDPRWAEKAGCKFSNGDMHDQFGYRAYLRLLTSPIRVLRGTLARQVRIGMLDILGFTPAEYNNSSPDAQLCLACASRGFPVLILDKAQSWQYSSCCQTIAREAVDSFARESSRSIRWPEIALRNPHRGTWRFNAQGTPSRPFIGLSASRRHIMSLQVTNLLDLERWTQNYSARYTLRIILSIHMNSLPPTTSITGGHQRAKIGRAPVSGDPANGVWVAILRSDLRLDQGEVCYIEWCSPVALLVFPKTLSVLRKFFSAFGDRGCQSSCDGILVRWGRGCRPAMQVISSLNRLALNIGLSRLNSWSELDSFDVDTRWIVYLRVCCISDGPALYSIYSLSPHTKTPPRKLYHRSTLLSVLTPTWAEQSRLLPNLKRGPCVCQQSGVLHSLQQLHPQLSAKPFRTKGLAPGSRPTVRPPLACPATNSKDRQFLSPSSHSGIMPFYPIPKHCEPWVDTSLKSRCGCRTEQLRSLNVTHTEANGASGHLPGAALADSLVHGASLRLKDCPPPPEGSDVCMAWGYRQPQMSQNQRPLEPRLRAHAWGAYSCNDIRRRLPPLESAVRSHLVRVCDLVPACRWHGTGVPSFHVGGVPSAGSPVRYSYAPPNPAAGLSDSGHVIARKDLTPTWDWSTRVQIRRNPDSWTWSAGVGIPVIPKAQHFERITGALQTTVRTRGTGDPPLPRICSLRNNAQKLIALAATYIACRINNFHMCGNLARERKDLPQRLYYPYILRDAYWILRGVLLPLTDPDLLYSLSSKKCLTCLSSKVALLYYKEARFVDLAPTPAPLESTITRYCFGPAPQRYIYRPKYRRPNVVTSSLSEPLVLMINGAGQTLCPKMGALALESEESRFAECSFHRLPRPGVVNVSHTIWTKKLRSSRFQIGILNVCCSSKDLFDYKLPASLPVHLNIPSFLKRLKTLSRATLLFRRVIGLGRQRLNPFSLINLHSESFHFKSHQCSATVESRRVRIHTAAFIVTNVWQVTGPHIGFYLVPAVSNVARSLYTALLELSPQGPSIRPYRSAETHPLDLIRAVTYRLRISRAGVEPSKILPRLNIQLVRASATKEYPGSERGLVAAICSPGREASVIYYLGQDSPFVALCDHPALSVCRRTGAKNESILQLCQPTLGRSSYGHVNSHRSGRSAVVVARRHYVLEHCRKSPPPRHSLRHLTRKGPQSIKLSSLAPREQSCRQLTATHRVAQDLHNAALGVLRLLGLEPGLFVTHDGDGDSRRINANSGVVRVLAEFAPRMIMRRADVNRNPYLNSLDERCPSESAERFFSHGPISCQGRYWWARRCSCRTTRQWRHRVQRTQFVVIVCCRQAHRDRPDESAEERTNKGDLGDHSLLLLAVLGNDPHTQVLTRFEAIRARSWASARLASILVACTHSVAKARTLVSHIALEQPGEPFANPVCFVYHTVLCGEFGSLRKCTTNASLKPWRLRSVLKTLEELTLYYSSTVSVDLLVWHRTIGLDNSGGRVWKFYQHNKLPRGVTLVLPCSAASDNVCSLSQSACVKISFPLNPQGLCRMQRYTKKRVMWRGSDEGQRIESLSMTDSIISPIISKAGVRVRAAREPGPMRLVWDVSCSGTRRWRTRRRTRMKNNFAASRLPTTPEGQYSPGMRSHIPDAPVRRAVLASSNRASMAHMLGSRGVRGRCQFCKNRSREAIEFRRRPMSVGKPGSPKAEAVSAVGDLGYVAINRDHLQVGLTRIIYQRLQAIFVPFVTSSTHTHPWQCWDTILEPHTSALAAISYAGNGKPCWQLTTLHQLVAEGLDSLRSEIYYQATYPTKDRNSLQISSRLPVLVQDAMNGAFLLLRCTARICAVRPDCHTCHIDYAFRLRLGGDPLRNLYAWLGAG

