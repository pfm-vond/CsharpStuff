using (TS ts = new TS(option.Required)){
    // insert 1

    try 
    using (TS ts = new TS(option.RequiredNew)){
        // insert 2

        // insert 3
        
        throw // 2 ET 3 SONT ROLLBACK
    }
    catch{}

    scope.complete() // 1 EST COMMIT
}

using (TS ts = new TS(option.Required)){
    // insert 1

    using (TS ts = new TS(option.RequiredNew)){
        // insert 2

        // insert 3
        
        scope.complete() // 2 ET 3 SONT COMMIT
    }

    throw // 1 EST rOLLBACK
}

using (TS ts1 = new TS(option.Required)){
    // insert 1

    try 
    using (TS ts2 = new TS(option.sUPRESS)){
        // insert 2 - OK // EXECUETEnONqUERY("insert INTO nUMBERtABLE VALUE 2") INSERTION IMMEDIATE

        // insert 3 - INSERTION IMMEDIATE
        
        throw
    }
    catch{}

    ts1.complete() // 1 EST COMMIT
}

createId(){
    using (TS ts1 = new TS(option.Required)){
        // delete user in table userlegacy

        createUser();

        ts1.complete()
    } 
}


createUser(){    
    using (TS ts2 = new TS(option.Required)){
        // insert 2

        // insert 3
        
        ts2.complete() // 1, 2 ET 3 SONT COMMIT
    }
}



PUBLIC CLASS ts : dISPOSABLE
{
    TS(){
         BEFOREtRANSAC = tRANSAC.Current

        IF (tRANSACTIONpOOL.Current != NULL && OPTION == rEQUIRED)
        {
            DO NOTHING
        }
        ELSE IF(OPTION != sUPRESS){
            tRANSACTIONpOOL.Current = NEW tRANSACTION()
        }
        ELSE{
            tRANSACTIONpOOL.Current = NULL
        }

    }

    dISPOSE(){
        tRANSACTION.Current = BEFOREtRANSAC
    }
}