var TrgovanjeStavka = function (spec) {
    var self = {};

    if (undefined !== spec.ConcurrencyGuid) {
        self.ConcurrencyGuid = spec.ConcurrencyGuid;
    }

    if (undefined !== spec.Ponuda) {
        self.Ponuda = spec.Ponuda;
    }

    if (undefined !== spec.PonudaDodatak) {
        self.PonudaDodatak = spec.PonudaDodatak;
    }

    if (undefined !== spec.Potraznja) {
        self.Potraznja = spec.Potraznja;
    }

    if (undefined !== spec.PotraznjaDodatak) {
        self.PotraznjaDodatak = spec.PotraznjaDodatak;
    }

    if (undefined !== spec.Promet) {
        self.Promet = spec.Promet;
    }

    if (undefined !== spec.PrometDodatak) {
        self.PrometDodatak = spec.PrometDodatak;
    }

    if (undefined !== spec.TrgovanjeVrstaId) {
        self.TrgovanjeVrstaId = spec.TrgovanjeVrstaId;
    }

    if (undefined !== spec.ValutaId) {
        self.ValutaId = spec.ValutaId;
    }

    if (undefined !== spec.TrgovanjeGlavaId) {
        self.TrgovanjeGlavaId = spec.TrgovanjeGlavaId;
    }

    if (undefined !== spec.TrgovanjeStavkaId) {
        self.TrgovanjeStavkaId = spec.TrgovanjeStavkaId;
    }

    return self;
}

var TrgovanjeStavkaHnb = function (spec) {
    var self = {};

    if (undefined !== spec.ConcurrencyGuid) {
        self.ConcurrencyGuid = spec.ConcurrencyGuid;
    }

    if (undefined !== spec.IznosMilijuniKn) {
        self.IznosMilijuniKn = spec.IznosMilijuniKn;
    }

    if (undefined !== spec.KamatnaStopa) {
        self.KamatnaStopa = spec.KamatnaStopa;
    }

    if (undefined !== spec.TrgovanjeVrstaId) {
        self.TrgovanjeVrstaId = spec.TrgovanjeVrstaId;
    }

    if (undefined !== spec.TrgovanjeGlavaHnbId) {
        self.TrgovanjeGlavaHnbId = spec.TrgovanjeGlavaHnbId;
    }

    if (undefined !== spec.TrgovanjeStavkaId) {
        self.TrgovanjeStavkaHnbId = spec.TrgovanjeStavkaHnbId;
    }

    return self;
}