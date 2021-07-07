from pyvi import ViTokenizer
path = "document1.txt"
f = open(path,"r",encoding="utf-8")
e = f.read();

s_tt= ViTokenizer.tokenize(e)

fo = open("final.txt","w",encoding="utf-8")
fo.write(s_tt)
f.close()
fo.close()