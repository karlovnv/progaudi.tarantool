box.cfg{ listen = 3301 }
box.schema.user.passwd('')
box.schema.user.grant('guest','read,write,execute','universe')