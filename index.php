<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
        <title>Aula de WEB</title>
    </head>
    <body>
        <center><h2>Nota do aluno</h2></center>
        <hr/>
        <div class="row justify-content-center row-cols-1 row-cols-md-2 mb-3 text-center">
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sw">
                    <div class="card-header py-3">
                        &nbsp;&nbsp;<font style="font-size: 30px;"><b><svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-card-list" viewBox="0 0 16 16">
  <path d="M14.5 3a.5.5 0 0 1 .5.5v9a.5.5 0 0 1-.5.5h-13a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5zm-13-1A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h13a1.5 1.5 0 0 0 1.5-1.5v-9A1.5 1.5 0 0 0 14.5 2z"/>
  <path d="M5 8a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7A.5.5 0 0 1 5 8m0-2.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5m0 5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5m-1-5a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0M4 8a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0m0 2.5a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0"/>
</svg>Nota do aluno</b></font>
                    </div>
                    <div class="card-body">
                        <form action="resultado.php" method="post">
                            <label class="form-label">Digite a 1° nota</label>
                            <input class="form-control" type="number" name="n1" required placeholder="Digite um valor"/>
                            <br/>
                            <label class="form-label">Digite a 2° nota</label>
                            <input class="form-control" type="number" name="n2" required placeholder="Digite um valor"/>
                            <br/>
                            <label class="form-label">Digite a 3° nota</label>
                            <input class="form-control" type="number" name="n3" required placeholder="Digite um valor"/>
                            <br/>
                            <input type="submit" class="btn btn-outline-success" value="Ver media"/>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>

