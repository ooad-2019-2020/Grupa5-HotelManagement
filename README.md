# Grupa5-HotelManagement

Aplikacija je namijenjena u svrhu modernizovanja poslovanja uvođenjem informacionih tehnologija, kako bi usluge hotela učinila jednostavnijim, preglednijim i korisnički prihvatljivijim.

Glavni cilj aplikacije je da omogući rezervacije soba, te plaćanje u elektronskom obliku, ali da se osim toga izvrši informatizacija i ostalih ključnih poslovnih procesa u hotelu. Zbog načina dizajna i postavljenih ciljeva, sistem se naziva **E-HOTEL**. Projekat je open-source tipa, dakle dostupan je svima za korištenje. Link koji vas preusmjerava na glavni source projekta je sljedeći: ([https://github.com/ooad-2019-2020/Grupa5-HotelManagement](https://github.com/ooad-2019-2020/Grupa5-HotelManagement)).

U nastavku su dati osnovni akteri i njima pripadajuće funkcionalnosti.

## **Korisnik/Gost**

Korisnik se **registruje** prilikom pristupanja aplikaciji, čime se čuvaju njegovi lični podaci, a svakog narednog puta se **prijavljuje** sa svojim korisničkim imenom i šifrom. Ove informacije će biti sačuvane u cilju vođenja evidencije o gostima hotela.

Mogućnosti korisnika su date u nastavku:

- mogućnost **rezervacije sobe** , uz automatsko **dodjeljivanje parking mjesta** , ukoliko korisnik odabere da želi isto.
- **pregled dostupnih soba/apartmana** za rezervaciju, te pregled soba koje su već rezervisane ( i dalje ih može rezervisati u slobodnim terminima nakon isteka trenutno zabilježenih rezervacija)
- **pregled historije rezervisanih apartmana** ( u svrhu olakšavanja budućih rezervacija )
- **otkazivanje rezervacije** u specifičnim okolnostima ( način determiniranja naplate se obračunava na dogovoreni način )
- mogućnost **ocjenjivanja usluga i davanje komentara**
- **ostvarivanje popusta** – zbog čestog boravka u hotelu
- **kontakt/mail** sa zaposlenicima hotela u svrhu prijave problema/zahtjeva/želja
- **plaćanje kreditnom karticom**

## **Recepcioner**

Recepcioner dobija pristupne podatke od strane administratora koji ga je prethodno unio u bazu. Sa dobijenim pristupnim podacima se **prijavljuje** na sistem.

Mogućnosti recepcionera su date u nastavku:

- **pregled svih rezervacija** ( kako trenutnih tako i starih/isteklih )
- **pregled korisnika** koji su boravili u hotelu i broj boravaka u hotelu ( zbog evidencije o ostvarenom popustu )
- **pregled i uvid u informacijama svih soba** u hotelu
- **rezervacija sobe** – uključuje validaciju rezervacije tj. mogućnost odabira date sobe, te finalizaciju i potvrdu te rezervacije unošenjem u sistem.
- **kontakt/mail** sa korisnikom u svrhu rješavanja korisnikovih problema/zahtjeva i slično
- **odjavljivanje korisnika** u specifičnim uslovima
- **zaključivanje i obračun boravka**
- **održavanje sistema** – bilježenje svake nepoželjne akcije u tabele grešaka i eventualni reset sistema

## **Administrator**

Administrator nadgleda funkcionisanje cijelog sistema i ima nadzor nad svim dešavanjima u sistemu.

Mogućnosti administratora su date u nastavku:

- **sve mogućnosti recepcioniste**
- **dodavanje/uređivanje/brisanje računa zaposlenika** (u slučaju novih zaposlenika, promjene informacija već postojećih, te prestanka rada nekog raspolenika u hotelu)
- **blokiranje/brisanje računa korisnika** (iz bilo kojeg razloga kojeg smatra smislenim)
- **pregled informacija svih zaposlenika** – iako aplikacija nije namjenjena za svaki posao koji se obavlja u hotelu, administrator ima informacije o svim zaposlenicima koje su mu potrebne.
- **menadžment finansijama –** revizija cijena
- **specifikacija soba/apartmana**
- **dodatne informacije i funkcionalnosti  ** koje se tiču sistema

**\*\*prikladne slike (screenshot-i) za funkcionalnosti uskoro**
