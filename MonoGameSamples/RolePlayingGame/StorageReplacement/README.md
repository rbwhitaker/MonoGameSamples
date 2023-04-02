# Storage

The RPG sample in the XNA world heavily used the storage API. MonoGame no longer implements this, because it is a hard
problem to solve across wildly different systems, especially the consoles. However, this particular sample does not
need to support _all_ the platforms today to be useful, so this recovers a number of files from the MonoGame 3.5.1 release
for use in this program.