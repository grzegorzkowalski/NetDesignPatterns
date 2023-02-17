using PartyAdapter;

var nightClub = new NightClub();
var adult = new Adult("Jan", 33);
var teenager = new Teenager("Michał", 15);
var fakeAdult = new FakeAdult("Michał", 15);

nightClub.letsParty(adult);
nightClub.letsParty(teenager);
nightClub.letsParty(fakeAdult);