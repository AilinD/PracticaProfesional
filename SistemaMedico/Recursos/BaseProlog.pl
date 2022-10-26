SintomaDe(Tos,Gripe).
SintomaDe(DolorPecho,Gripe).
SintomaDe(Mareos,Gripe).
SintomaDe(Fiebre,Gripe).
SintomaDe(DolorCabeza,Gripe).

SintomaDe(Fiebre,Malaria).
SintomaDe(Vomitos,Malaria).
SintomaDe(Escalofrios,Malaria).
SintomaDe(DolorCabeza,Malaria).
SintomaDe(DolorMuscular,Malaria).

SintomaDe(Fiebre,Rubeola).
SintomaDe(Faringitis,Rubeola).
SintomaDe(InflamacionGanglios,Rubeola).
SintomaDe(OjosRojos,Rubeola).

SintomaDe(tos,Tuberculosis).
SintomaDe(Expectoracion,Tuberculosis).
SintomaDe(Sudor,Tuberculosis).

SintomaDe(Desnutricion,Anemia).
SintomaDe(Nauseas,Anemia).
SintomaDe(Vomitos,Anemia).

SintomaDe(ColorPielAmarillo,Hepatitis).
SintomaDe(Diarrea,Hepatitis).

Cargar(A):exists_file(A),consult(A).
SintomaDe(S,Z),M
EspecialistaDe(Otorrino,gripe).
EspecialistaDe(Nutricionista,Anemia).
EspecialistaDe(Endocrinologo,Hepatitis).
EspecialistaDe(Clinico,Rubeola).
EspecialistaDe(Nutricionista,Tuberculosis).
EspecialistaDe(Clinico,Malaria).
Atiende_Especialista(E,S):-SintomaDe(S,Z),EspecialistaDe(E,S)