using Strategy;
AppleMusic am = new AppleMusic(new PlayMusic());
am.DoIt();
am.st = new PlayPodcast();
am.DoIt();
Spotify sp = new Spotify(new ShowLyrics());
sp.DoIt();
sp.st = new PlayPodcast();
sp.DoIt();

