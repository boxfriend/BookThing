# BookThing

I wanted a quick way to help decide what to read from my ever growing backlog of books to read. Up until recently I had been using an online website like random.org to shuffle a small list of books to choose which to read next. This got tedious, especially as I had to reenter the list of books each time.
This app solves that problem, I store the books as individual entries in a SQLite database, then it just shuffles the list and I read what is on top.

This is a pretty basic .NET MAUI Blazor application with very simple CRUD functions. Then on the shuffle page it uses a Fisher-Yates shuffle combined with my own XORshift rng implementation. I definitely could have just used the System.Random class to get the random numbers for the shuffle but XORShift was incredibly simple to implement myself and is good enough for this.
