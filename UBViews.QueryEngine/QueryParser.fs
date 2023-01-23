// Implementation file for parser generated by fsyacc
module UBViews.LexParser.Parser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open FSharp.Text.Lexing
open FSharp.Text.Parsing.ParseHelpers
# 4 "QueryParser.fsy"


open UBViews.LexParser.Ast

let toFilterValue s =
    match s with
    | _ when s = "topid" || s = "TOPID" 
        -> FilterValue.TOPID
    | _ when s = "docid" || s = "DOCID" 
        -> FilterValue.DOCID
    | _ when s = "seqid" || s = "SEQID" 
        -> FilterValue.SEQID
    | _ when s = "parid" || s = "PARID" 
        -> FilterValue.PARID
    | _ when s = "secid" || s = "SECID" 
        -> FilterValue.SECID
    | _ -> failwith "Unknown FilterType"


# 26 "QueryParser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | FILTERBY
  | TOPID
  | DOCID
  | SEQID
  | PARID
  | SECID
  | FILTERID of (string)
  | AND
  | OR
  | TILDE
  | QUOTATION_MARK
  | LEFT_PAREN
  | RIGHT_PAREN
  | LEFT_BRACKET
  | RIGHT_BRACKET
  | STERM of (string)
  | TERM of (string)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_FILTERBY
    | TOKEN_TOPID
    | TOKEN_DOCID
    | TOKEN_SEQID
    | TOKEN_PARID
    | TOKEN_SECID
    | TOKEN_FILTERID
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_TILDE
    | TOKEN_QUOTATION_MARK
    | TOKEN_LEFT_PAREN
    | TOKEN_RIGHT_PAREN
    | TOKEN_LEFT_BRACKET
    | TOKEN_RIGHT_BRACKET
    | TOKEN_STERM
    | TOKEN_TERM
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_UserQuery
    | NONTERM_SingleQuery
    | NONTERM_FilterId
    | NONTERM_Phrase
    | NONTERM_CTerm

// This function maps tokens to integer indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | FILTERBY  -> 1 
  | TOPID  -> 2 
  | DOCID  -> 3 
  | SEQID  -> 4 
  | PARID  -> 5 
  | SECID  -> 6 
  | FILTERID _ -> 7 
  | AND  -> 8 
  | OR  -> 9 
  | TILDE  -> 10 
  | QUOTATION_MARK  -> 11 
  | LEFT_PAREN  -> 12 
  | RIGHT_PAREN  -> 13 
  | LEFT_BRACKET  -> 14 
  | RIGHT_BRACKET  -> 15 
  | STERM _ -> 16 
  | TERM _ -> 17 

// This function maps integer indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_FILTERBY 
  | 2 -> TOKEN_TOPID 
  | 3 -> TOKEN_DOCID 
  | 4 -> TOKEN_SEQID 
  | 5 -> TOKEN_PARID 
  | 6 -> TOKEN_SECID 
  | 7 -> TOKEN_FILTERID 
  | 8 -> TOKEN_AND 
  | 9 -> TOKEN_OR 
  | 10 -> TOKEN_TILDE 
  | 11 -> TOKEN_QUOTATION_MARK 
  | 12 -> TOKEN_LEFT_PAREN 
  | 13 -> TOKEN_RIGHT_PAREN 
  | 14 -> TOKEN_LEFT_BRACKET 
  | 15 -> TOKEN_RIGHT_BRACKET 
  | 16 -> TOKEN_STERM 
  | 17 -> TOKEN_TERM 
  | 20 -> TOKEN_end_of_input
  | 18 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | 2 -> NONTERM_UserQuery 
    | 3 -> NONTERM_UserQuery 
    | 4 -> NONTERM_UserQuery 
    | 5 -> NONTERM_SingleQuery 
    | 6 -> NONTERM_SingleQuery 
    | 7 -> NONTERM_SingleQuery 
    | 8 -> NONTERM_SingleQuery 
    | 9 -> NONTERM_SingleQuery 
    | 10 -> NONTERM_SingleQuery 
    | 11 -> NONTERM_SingleQuery 
    | 12 -> NONTERM_SingleQuery 
    | 13 -> NONTERM_FilterId 
    | 14 -> NONTERM_Phrase 
    | 15 -> NONTERM_Phrase 
    | 16 -> NONTERM_CTerm 
    | 17 -> NONTERM_CTerm 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 20 
let _fsyacc_tagOfErrorTerminal = 18

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | FILTERBY  -> "FILTERBY" 
  | TOPID  -> "TOPID" 
  | DOCID  -> "DOCID" 
  | SEQID  -> "SEQID" 
  | PARID  -> "PARID" 
  | SECID  -> "SECID" 
  | FILTERID _ -> "FILTERID" 
  | AND  -> "AND" 
  | OR  -> "OR" 
  | TILDE  -> "TILDE" 
  | QUOTATION_MARK  -> "QUOTATION_MARK" 
  | LEFT_PAREN  -> "LEFT_PAREN" 
  | RIGHT_PAREN  -> "RIGHT_PAREN" 
  | LEFT_BRACKET  -> "LEFT_BRACKET" 
  | RIGHT_BRACKET  -> "RIGHT_BRACKET" 
  | STERM _ -> "STERM" 
  | TERM _ -> "TERM" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | FILTERBY  -> (null : System.Object) 
  | TOPID  -> (null : System.Object) 
  | DOCID  -> (null : System.Object) 
  | SEQID  -> (null : System.Object) 
  | PARID  -> (null : System.Object) 
  | SECID  -> (null : System.Object) 
  | FILTERID _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | AND  -> (null : System.Object) 
  | OR  -> (null : System.Object) 
  | TILDE  -> (null : System.Object) 
  | QUOTATION_MARK  -> (null : System.Object) 
  | LEFT_PAREN  -> (null : System.Object) 
  | RIGHT_PAREN  -> (null : System.Object) 
  | LEFT_BRACKET  -> (null : System.Object) 
  | RIGHT_BRACKET  -> (null : System.Object) 
  | STERM _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | TERM _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us;65535us;1us;65535us;0us;1us;1us;65535us;0us;2us;5us;65535us;0us;4us;2us;5us;18us;15us;19us;16us;20us;17us;1us;65535us;22us;23us;1us;65535us;9us;10us;1us;65535us;12us;13us;|]
let _fsyacc_sparseGotoTableRowOffsets = [|0us;1us;3us;5us;11us;13us;15us;|]
let _fsyacc_stateToProdIdxsTableElements = [| 1us;0us;1us;0us;3us;1us;2us;4us;1us;2us;4us;3us;9us;10us;12us;4us;4us;9us;10us;12us;1us;5us;1us;6us;1us;6us;1us;7us;2us;7us;15us;1us;7us;1us;8us;2us;8us;17us;1us;8us;4us;9us;9us;10us;12us;4us;9us;10us;10us;12us;4us;9us;10us;11us;12us;1us;9us;1us;10us;1us;11us;1us;11us;1us;12us;1us;12us;1us;13us;1us;14us;1us;15us;1us;16us;1us;17us;|]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us;2us;4us;8us;10us;15us;20us;22us;24us;26us;28us;31us;33us;35us;38us;40us;45us;50us;55us;57us;59us;61us;63us;65us;67us;69us;71us;73us;75us;|]
let _fsyacc_action_rows = 29
let _fsyacc_actionTableElements = [|5us;32768us;10us;7us;11us;9us;12us;20us;14us;12us;17us;6us;0us;49152us;6us;16385us;0us;3us;10us;7us;11us;9us;12us;20us;14us;12us;17us;6us;0us;16386us;3us;16387us;1us;22us;8us;18us;9us;19us;3us;16388us;1us;22us;8us;18us;9us;19us;0us;16389us;1us;32768us;17us;8us;0us;16390us;1us;32768us;17us;25us;2us;32768us;11us;11us;17us;26us;0us;16391us;1us;32768us;17us;27us;2us;32768us;15us;14us;17us;28us;0us;16392us;0us;16393us;0us;16394us;4us;32768us;1us;22us;8us;18us;9us;19us;13us;21us;5us;32768us;10us;7us;11us;9us;12us;20us;14us;12us;17us;6us;5us;32768us;10us;7us;11us;9us;12us;20us;14us;12us;17us;6us;5us;32768us;10us;7us;11us;9us;12us;20us;14us;12us;17us;6us;0us;16395us;1us;32768us;7us;24us;0us;16396us;0us;16397us;0us;16398us;0us;16399us;0us;16400us;0us;16401us;|]
let _fsyacc_actionTableRowOffsets = [|0us;6us;7us;14us;15us;19us;23us;24us;26us;27us;29us;32us;33us;35us;38us;39us;40us;41us;46us;52us;58us;64us;65us;67us;68us;69us;70us;71us;72us;|]
let _fsyacc_reductionSymbolCounts = [|1us;1us;2us;1us;2us;1us;2us;3us;3us;3us;3us;3us;3us;1us;1us;2us;1us;2us;|]
let _fsyacc_productionToNonTerminalTable = [|0us;1us;2us;2us;2us;3us;3us;3us;3us;3us;3us;3us;3us;4us;5us;5us;6us;6us;|]
let _fsyacc_immediateActions = [|65535us;49152us;65535us;16386us;65535us;65535us;16389us;65535us;16390us;65535us;65535us;16391us;65535us;65535us;16392us;65535us;65535us;65535us;65535us;65535us;65535us;16395us;65535us;16396us;16397us;16398us;16399us;16400us;16401us;|]
let _fsyacc_reductions = lazy [|
# 206 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> Ast.Query list in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : 'gentype__startstart));
# 215 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_UserQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 47 "QueryParser.fsy"
                                        _1 
                   )
# 47 "QueryParser.fsy"
                 : Ast.Query list));
# 226 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_UserQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 50 "QueryParser.fsy"
                                                _1 
                   )
# 50 "QueryParser.fsy"
                 : 'gentype_UserQuery));
# 237 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_SingleQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 51 "QueryParser.fsy"
                                                [_1] 
                   )
# 51 "QueryParser.fsy"
                 : 'gentype_UserQuery));
# 248 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_UserQuery in
            let _2 = parseState.GetInput(2) :?> 'gentype_SingleQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 52 "QueryParser.fsy"
                                                _2 :: _1 
                   )
# 52 "QueryParser.fsy"
                 : 'gentype_UserQuery));
# 260 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 55 "QueryParser.fsy"
                                                               Term(_1)         
                   )
# 55 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 271 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 56 "QueryParser.fsy"
                                                               STerm(_2)        
                   )
# 56 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 282 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_Phrase in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 57 "QueryParser.fsy"
                                                               Phrase(_2)       
                   )
# 57 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 293 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_CTerm in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 58 "QueryParser.fsy"
                                                               CTerm (_2)       
                   )
# 58 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 304 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_SingleQuery in
            let _3 = parseState.GetInput(3) :?> 'gentype_SingleQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 59 "QueryParser.fsy"
                                                               And(_1, _3)      
                   )
# 59 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 316 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_SingleQuery in
            let _3 = parseState.GetInput(3) :?> 'gentype_SingleQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 60 "QueryParser.fsy"
                                                               Or(_1, _3)       
                   )
# 60 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 328 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _2 = parseState.GetInput(2) :?> 'gentype_SingleQuery in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 61 "QueryParser.fsy"
                                                               SubQuery(_2)     
                   )
# 61 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 339 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_SingleQuery in
            let _3 = parseState.GetInput(3) :?> 'gentype_FilterId in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 62 "QueryParser.fsy"
                                                            FilterBy(_1, toFilterValue(_3) ) 
                   )
# 62 "QueryParser.fsy"
                 : 'gentype_SingleQuery));
# 351 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 65 "QueryParser.fsy"
                                   _1 
                   )
# 65 "QueryParser.fsy"
                 : 'gentype_FilterId));
# 362 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 68 "QueryParser.fsy"
                                      [_1] 
                   )
# 68 "QueryParser.fsy"
                 : 'gentype_Phrase));
# 373 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_Phrase in
            let _2 = parseState.GetInput(2) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 69 "QueryParser.fsy"
                                      _2 :: _1 
                   )
# 69 "QueryParser.fsy"
                 : 'gentype_Phrase));
# 385 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 72 "QueryParser.fsy"
                                      [_1] 
                   )
# 72 "QueryParser.fsy"
                 : 'gentype_CTerm));
# 396 "QueryParser.fs"
        (fun (parseState : FSharp.Text.Parsing.IParseState) ->
            let _1 = parseState.GetInput(1) :?> 'gentype_CTerm in
            let _2 = parseState.GetInput(2) :?> string in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 73 "QueryParser.fsy"
                                     _2 :: _1 
                   )
# 73 "QueryParser.fsy"
                 : 'gentype_CTerm));
|]
# 409 "QueryParser.fs"
let tables : FSharp.Text.Parsing.Tables<_> = 
  { reductions = _fsyacc_reductions.Value;
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 21;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = tables.Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : Ast.Query list =
    engine lexer lexbuf 0 :?> _
