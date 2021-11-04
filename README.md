# Progetto-Officina-Riparazioni
NOME E COGNOME: TOMMASO REMEDI
TITOLO DEL PROGETTO: OFFICINA RIPARAZIONI
SPECIFICA: Il progetto consiste nella simulazione di una giornata di lavoro in un’officina di auto. 
All’interno di questa officina c’è un meccanico che a inizio giornata prende in input da un file di testo tutte le auto con le relative condizioni dei vari pezzi(motore,gomme,sospensioni,fari,freni e batteria) su cui dovrà lavorare quel giorno e le mette in una lista. Per ogni macchina prima controlla lo stato di ogni singolo pezzo, che se risulterà sotto la soglia della sufficienza  andrà riparato o eventualmente sostituito. Per decidere se un pezzo verrà sostituito o andrà riparato viene sommato alle condizioni di quel pezzo un modificatore fortuna di [-3;+3], se grazie all’aggiunta di questo modificatore il pezzo supera la soglia della sufficienza allora esso verrà riparato, con una spesa dimezzata per il cliente che verrà aggiunta all’entrate  dell’officina. In caso questo modificatore non bastasse il cliente dovrà pagare il prezzo pieno, l’officina aggiunge alle spese del fornitore il prezzo della riparazione scontato del 20% ed aggiunge alle entrate il prezzo pieno della riparazione.
Quando il meccanico ha controllato tutte le auto termina il programma mostrando a terminale il guadagno giornaliero.
Viene anche implementata una funzione di log che tiene traccia in un file di testo di tutti i lavori eseguiti sulle auto durante questa giornata.
Ho deciso di implementare due pattern, uno creazionale(singleton) sulla classe Officina ed uno comportamentale(state pattern) per il meccanico.
Viene implementata anche la fattura finale in formato XML contenente per ogni auto, marca, modello e conto.
