# VStudio

Tento projekt má 2 projekty, DSAR a MilEncryptor.

Zde je vysvětlení, co musí každý z kodů dělat:


1. DSAR (Knihovna Tříd)
   - Toto je pouze knihovna tříd, která bude obsahovat pouze funkce pro šifrování a dešifrování dat.
   - Jsou zde třídy Encrypt.cs a Decrypt.cs. 



3. MilEncryptor (C# Forms .NET Framework 4.8)
   - Toto je hlavní projekt, který bude sloužit pro šifrování a dešifrování souborů speciálním způsobem.
   - Je zapotřebí, aby tento projekt správně pracoval s daty z dynamické knihovny DSAR.dll (DSAR.sln).
   - Zde jsou popisy, co by měl program umět:
     * Šifrovat soubor a soubory ve složce
     * Výsledné zašifrované soubory se budou ukládat do souborů se speciálními názvy.
     * Program by měl umět využívat kompresi, pokud je zaškrtnuto 'UseCompressCheckBox'.
     * Měl by umět využívat enigmu v případě zaškrtnutí 'EnableEnigmaEncCheckBox' pro názvy souborů v zašifrovaném souboru ve formátu '<milchunk/ENIGMA_NAZEV>.
     * Jako klíč, by měl umět využívat 128/192 nebo 256 bitový Hex klíč, nebo string, který v případě, že bude krátký, tak se doplní paddingem. O tom co je zvoleno rozhoduje 'KeyTypeEncComboBox'.

! Data obsažená v ComboBoxech:
  - EncryptDatatypeComboBox (File, Folder)
  - AlgorithmComboBox (DSAR, MILSAT-4570, KY-99, THALES3000, RM10-CRY70)
  - EncryptToComboBox (Datafile, Pakchunk)
  - KeyTypeEncComboBox (HEX 128/192 or 256 bit, String Password (MAX 32))
  - ClassComboBox (UNCLASSIFIED, RESTRICTED, CONFIDENTIAL, SECRET, TOP SECRET)
  - AuthorityComboBox (NATO, DoD, FBI, CIA, NSA, INTERPOL, MOSSAD, NCIS, NAVY)

3.Funkcionalita:
  - Vezměme si příklad, že máme soubor 'IMG_45987.jpg' a chceme ho zašifrovat. Vyberu v programu tedy tato data: "EncryptDatatypeComboBox=File;AlgorithmComboBox=DSAR;EncryptToComboBox=Datafiles;KeyTypeEncComboBox=HEX 128/192 or 256 bit;ClassomboBox=UNCLASSIFIED;AuthorityComboBox=NATO;DeleteAfterEncCheckBox=Checked;LeaveOrigNamesCheckBox=Checked;UseCompressCheckBox=Checked;EnableEnigmaEncCheckBox=Checked;EnigmaRotationsCountTextBox=3;PasswordEncTextBox=A4904D993AC5F52090F3A90EB41C3FA8BCF2E771C9DC2CE950F594C193FBC786". Poté co jsem zadal tato data, tak jsem programu dal najevo, že má Šifrovat pouze jeden soubor (EncryptDatatypeComboBox), že custom header má být ".DSAR.mil!pakdata.conf" (AlgorithmComboBox), že má soubor zašifrovat do jednoho souboru (EncryptToComboBox) se stejným názvem, jak se soubor originálně jmenoval (LeaveOrigNamesCheckBox), takže v našem případě by se jmenoval 'IMG_45987.jpg-data0.mil nikoliv 'data0.mil', dále že jako klíč pro Dynamickou třídu Encrypt.cs, se má využít HEX (V příkladu byl zadán 256 bitový)(KeyTypeEncComboBox), dále že soubor je typu UNCLASSIFIED (ClassComboBox), což pouze ovlivní baj na offsetu 0x00000004, dále že Autorita je NATO (AuthorityComboBox), což opět ovlivní pouze bajt na offsetu 0x00000005, dále že se má soubor smazat ihned po zašifrování (DeleteAfterEncCheckBox), dále že se má použít komprese (UseCompressCheckBox), dále že se má používat enigma (EnableEnigmaEncCheckBox), dále že počet otáček enigmy jsou 3 (EnigmaRotationsCountTextBox), takže soubor se bude v zašifrovaném souboru jmenovat v uvaděči názvu '<milchunk/LPJ_45987.msj>', a nakonec samotné heslo (PasswordEncTextBox). Takže data v zašifrovaném souboru by měla vypadat nějak takto: "54C6AD37B937F6CC1497632E445341522E6D696C2170616B646174612E636F6E663C6D696C6368756E6B2F4C504A5F34353938372E6D736A3E#############################", kde haštagy předsatvují už samotná zašifrovaná data.

  - Další příklad, udělám úplně to samý co v prvním příkladu, jen s tím rozdílem, že nastavím 'EncryptToComboBox=Pakchunk' namísto 'EncryptToComboBox=Datafiles'. Data se tak uloží úplně stejně beze změny jen s tím rozdílem, že se soubor nebude teď jmenovat 'IMG_45987.jpg-data0.mil', ale 'IMG_45987-pakchunk0.milpak'.

  - Další příklad, mám složku 'Dokumenty' ve které mám třeba soubory 'IMG_43975.jpg, dynapi.dll a config.xlsx' a tyto data chci zašifrovat. Vyberu v programu tedy tato data pro příklad: "EncryptDatatypeComboBox=Folder;AlgorithmComboBox=DSAR;EncryptToComboBox=Datafiles;KeyTypeEncComboBox=HEX 128/192 or 256 bit;ClassomboBox=UNCLASSIFIED;AuthorityComboBox=NATO;DeleteAfterEncCheckBox=Checked;LeaveOrigNamesCheckBox=Checked;UseCompressCheckBox=Checked;EnableEnigmaEncCheckBox=Checked;EnigmaRotationsCountTextBox=3;PasswordEncTextBox=A4904D993AC5F52090F3A90EB41C3FA8BCF2E771C9DC2CE950F594C193FBC786". Poté co jsem zadal tato data, a stiskl 'EncryptButton', tak se data ve složce zašifrovala podobným způsobem jako v příkladu jedna jen trochu jinak. Ve stejné složce, ve které jsou soubory co jsem chtěl zašifrovat se vytvoří nová složka s názvem 'NAZEV_AKTUALNI_SLOZKY-encrypted', kde NAZEV_AKTUALNI_SLOZKY je nazev, ve které složce se tyto data nacházela. Zašifrované soubory se tedy uloží do 'Dokumenty-encrypted', a názvy zašifrovaných souborů budou 'IMG_43975.jpg-data0.mil, dynapi.dll-data0.mil a config.xlsx', pokud bych místo toho v konfiguraci vybral 'LeaveOrigNamesCheckBox=Unchecked', tak by se soubory uložily do složky ve formátu 'data0.mil, data1.mil a data3.mil'. Takže jednoduše řečeno, každý soubor ve složce, se zašifruje do svého vlastního souboru.

  - V dalším příkladě provedeme to stejné co v příkladě 3 jen s rozdílem, že nastavíme 'EncryptToComboBox=Pakchunk' namísto 'EncryptToComboBox=Datafiles'. To řekne programu, že má veškeré soubory co jsou ve složce, zašifrovat do jednoho jediného souboru, se jménem '<NAZEV_AKTUALNI_SLOZKY>-pakchunk0.milpak', takže zde odpadá nutnost mít nastavené 'LeaveOrigNamesCHeckBox'. Data se do zašifrovaného souboru uloží následujícím způsobem "HALVIČKA, CUSTOM_STRING_ALGORITHMCOMBOBOX, SOUBOR1_NAZEV, DATA_SOUBORU_1_ZASIFROVANA, SOUBOR2_NAZEV, DATA_SOUBORU_2_ZASIFROVANA, SOUBOR3_NAZEV, DATA_SOUBORU_3_ZASIFROVANA". Takže data by v souboru po otevření měla vypadat nějak takto '55C6AE37B937F6CC1497632E445341522E6D696C2170616B646174612E636F6E663C6D696C6368756E6B2F667271696C6A2E616F76613E<ZAŠIFROVANÁ_DATA_SOUBORU_config.xlsx>3C6D696C6368756E6B2F67627164736C2E676F6F3E<ZAŠIFROVANÁ_DATA_SOUBORU_dynapi.dll>3C6D696C6368756E6B2F4C504A5F34333937352E6D736A3E', samozřejmě soubory by se šifrovali do .milpak abecedně.

4. Formáty názvů souborů:
   - Pro pakchunk s výběrem File: <NAZEV_SOUBORU_CO_SE_SIFRUJE>-pakchunk<INDEX>.milpak. Pokud 'LeaveOrigNamesCheckBox=Unchecked' -> pakchunk<INDEX>.milpak.
   - Pro datafile s výběrem File: <NAZEV_SOUBORU_CO_SE_SIFRUJE>-data<INDEX>.mil. Pokud 'LeaveOrigNamesCheckBox=Unchecked' -> data<INDEX>.mil.
   - Pro pakchunk s výběrem Folder:  <NAZEV_SLOZKY_VE_KTERÉ_SOUBORY_JSOU>-pakchunk<INDEX>.milpak. Pokud 'LeaveOrigNamesCheckBox=Unchecked' -> pakchunk<INDEX>.milpak.
   - Pro datafile s výběrem Folder:  <NAZEV_SOUBORU_CO_SE_SIFRUJE>-data<INDEX>.mil, ale ve složce <NAZEV_SLOZKY_VE_KTERE_SOUBORY_JSOU>-encrypted. Pokud 'LeaveOrigNamesCheckBox=Unchecked' -> data<INDEX>.mil ve složce <NAZEV_SLOZKY_VE_KTERE_SOUBORY_JSOU>-encrypted.
