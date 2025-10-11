using SistemaConcurso.Domain.Interfaces.Ai;

namespace SistemaConcurso.Domain.Services;

public class PdfMockService : IPdfService
{
    public string PdfToString(byte[] pdf)
    {
        return """
               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               CONCURSO PÚBLICO 
               EDITAL N.º 001/2025 

               A Prefeitura Municipal de Biguaçu, por meio da Secretaria Municipal de Administração, no uso de suas 
               atribuições legais e regulamentares, torna público o Edital de abertura para a realização do Concurso Público, 
               Edital n.º 001/2025, destinado ao preenchimento de vagas existentes e à formação de cadastro de reserva 
               da Administração Direta da Prefeitura Municipal de Biguaçu, que reger-se-á pela Lei Orgânica do Município, 
               Lei Complementar n.º 53, de 04 de julho de 2012, e suas alterações, e pelas normas estabelecidas neste 
               Edital. O cronograma previsto para o Concurso Público está disposto no quadro a seguir: 

               CRONOGRAMA DO CONCURSO PÚBLICO 

               EVENTOS DATAS 

               Publicação do Edital 27/06/2025 

               Período de solicitação de impugnação do Edital 28/06/2025 a 01/07/2025 

               Publicação da resposta às solicitações de impugnação do Edital 04/07/2025 

               Período de Inscrições 

               Período de entrega dos documentos de PcD 07/07/2025 a 07/08/2025 

               Período de solicitação de condições especiais para a prova 

               Período de pedido de isenção da taxa de inscrição 07/07/2025 a 16/07/2025 

               Resposta aos pedidos de isenção da taxa de inscrição 28/07/2025 

               Período de recurso da isenção da taxa de inscrição 29/07/2025 a 30/07/2025 

               Resposta aos recursos da isenção da taxa de inscrição 04/08/2025 

               Último dia de pagamento da taxa de inscrição 08/08/2025 

               Publicação das inscrições deferidas 

               Publicação dos resultados das solicitações de PcD 11/08/2025 

               Publicação da resposta às solicitações de condições especiais 

               Período de recurso das inscrições indeferidas 

               Período de recurso das solicitações de PcD 12/08/2025 a 13/08/2025 

               Período de recurso dos indeferimentos de condições especiais 

               Publicação da resposta aos recursos das inscrições indeferidas 

               Publicação da resposta aos recursos das solicitações de PcD 
               18/08/2025 

               Publicação da resposta aos recursos das condições especiais 

               Homologação dos inscritos 

               Publicação do local e salas da prova objetiva 20/08/2025 

               PROVA OBJETIVA 31/08/2025 

               Publicação do gabarito preliminar e dos cadernos de prova 01/09/2025 

               Período de recurso da prova objetiva 02/09/2025 a 03/09/2025 

               Publicação da resposta aos recursos da prova objetiva 

               Publicação do resultado da prova objetiva - Gabarito oficial 
               18/09/2025 

               Publicação da relação de candidatos convocados para a prova prática  

               Publicação do local e horário da prova prática 

               PROVA PRÁTICA 28/09/2025 

               Publicação do resultado preliminar da prova prática  29/09/2025 

               Período de recurso da prova prática  30/09/2025 a 01/10/2025 

               Publicação da resposta aos recursos da prova prática  

               Publicação do resultado da prova prática  07/10/2025 

               Publicação do resultado preliminar do Concurso Público 

               Período de recurso do resultado preliminar do Concurso Público 08/10/2025 a 09/10/2025 

               Publicação da resposta aos recursos do resultado preliminar do Concurso Público 16/10/2025 

               Publicação do resultado final do Concurso Público 17/10/2025 

               1 DAS DISPOSIÇÕES PRELIMINARES 

               1.1 Os candidatos investidos no cargo estarão subordinados ao regime jurídico estatutário, à égide do 
               Estatuto dos Servidores Públicos do Município de Biguaçu, nos termos da Lei Complementar n.º 53, de 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 1 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               04 de julho de 2012, e suas alterações. 

               1.2 A realização do Concurso Público será de responsabilidade da Fundação Universidade Regional de 
               Blumenau – FURB. 

               1.3 O acompanhamento de todo o processo do Concurso Público será de responsabilidade da Comissão 
               para planejar, executar e fiscalizar a Realização do Concurso Público, designada pela Secretária 
               Municipal de Administração, da Prefeitura Municipal de Biguaçu, por meio da Portaria n.º 2.867, de 30 
               de abril de 2025. 

               1.4 O cronograma previsto para realização do Concurso Público poderá ser alterado por motivo de ordem 
               técnica e/ou operacional. Quaisquer alterações serão comunicadas no endereço eletrônico 
               http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025. 

               1.4.1 Todos os horários definidos neste Edital seguem o oficial da cidade de Brasília/DF. 

               1.5 O concurso público terá validade de até 2 (dois) anos, podendo ser prorrogado apenas uma vez, por 
               igual período. 

               1.6 A inscrição do candidato implicará o conhecimento e a aceitação irrestrita das instruções e das 
               condições do Concurso Público, tais como se acham estabelecidas neste Edital, bem como em 
               eventuais aditamentos, comunicações, instruções e convocações relativas ao certame, que passarão 
               a fazer parte do instrumento convocatório como se nele estivessem transcritos e acerca dos quais não 
               poderá o candidato alegar desconhecimento. 

               1.7 Qualquer cidadão poderá impugnar, de forma fundamentada, o presente Edital, no prazo de 4 (quatro) 
               dias corridos, contados a partir do primeiro dia subsequente à sua publicação, exclusivamente por meio 
               do endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 
               001/2025, por meio do ícone Impugnação contra o Edital, seguindo as orientações disponíveis na 
               página. 

               1.8 A FURB e a Prefeitura Municipal de Biguaçu analisarão todas as solicitações de impugnação. As 
               respostas serão publicadas no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de 
               Biguaçu - Edital n.º 001/2025. 

               2 DOS CARGOS, DA CARGA HORÁRIA SEMANAL, DOS VENCIMENTOS E REQUISITOS 

               2.1 Os cargos, a carga horária semanal de trabalho, os requisitos e os vencimentos para o exercício dos 
               cargos estão estabelecidos no Anexo I deste Edital. 

               2.2 São requisitos básicos para a investidura em cargo público de caráter efetivo, de acordo com a Lei 
               Complementar n.º 53/2012: 

               I. a aprovação em concurso público; 
               II. a prova da nacionalidade; 
               III. o gozo dos direitos políticos; 
               IV. a quitação com as obrigações militares, para os homens; 
               V. a quitação com as obrigações eleitorais; 
               VI. a idade mínima de 18 (dezoito) anos; 
               VII. o nível de escolaridade exigido para o exercício do cargo; 
               VIII. a comprovação da aptidão física e mental para exercício do cargo; 
               IX. declaração de não acumulação ou de acumulação lícita de cargos, empregos ou funções 

               públicas, inclusive se já aposentado em outro cargo ou emprego público; 
               X. declaração de ausência de impedimento de exercício de cargo, emprego ou função pública; 
               XI. declaração da não percepção de proventos aposentadoria por invalidez, pagos por qualquer 

               regime previdenciário; e 
               XII. Certidão Negativa de Antecedentes Criminais, de acordo com a Lei Ordinária n.º 4371/2025. 

               2.3 As atribuições dos cargos são as constantes no Anexo II deste Edital. 

               3 DAS INSCRIÇÕES 

               3.1 A inscrição poderá ser efetuada no período compreendido entre 8h do dia 07 de julho de 2025 e 
               23h59min do dia 07 de agosto de 2025. 

               3.2 O candidato deverá, antes de efetuar a inscrição, conhecer os termos deste Edital e certificar-se de que 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 2 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               atenderá a todos os requisitos exigidos para o cargo. 

               3.2.1 A participação no Concurso Público inicia-se pela inscrição do candidato e implica o conhecimento e a 
               tácita aceitação das normas e condições estabelecidas neste Edital e das decisões que possam ser 
               tomadas pela Comissão do Concurso Público. 

               3.3 Para se inscrever no Concurso Público, o candidato deverá, durante o prazo de inscrição: 

               a) acessar o endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital 
               n.º 001/2025; 

               b) acessar o ícone Inscrição online no site do certame e, no formulário eletrônico de inscrição, 
               cadastrar/atualizar suas informações pessoais, selecionar o cargo a que pretende concorrer, enviar 
               os documentos solicitados, conforme o caso, e, ao finalizar a inscrição, efetuar o pagamento por 
               meio de boleto bancário, ou ainda, solicitar a isenção de taxa, conforme prazos e condições. 

               3.3.1 O correto preenchimento do formulário eletrônico de inscrição e o envio de documentos solicitados, 
               conforme o caso, são de total responsabilidade do candidato. 

               3.3.2 A FURB não se responsabiliza por solicitações de inscrição e/ou pagamentos da taxa de inscrição não 
               recebidos por motivos de ordem técnica dos computadores, falhas de comunicação, congestionamento 
               das linhas de comunicação, fraudes virtuais, códigos maliciosos (vírus), bem como outros fatores de 
               ordem técnica que impossibilitem a transferência de dados. 

               3.4 O candidato poderá inscrever-se para até 02 (dois) cargos distintos, respeitado o período de 
               realização das provas, sendo: 

               • um cargo de nível Fundamental ou Médio/Técnico e 
               • um cargo de nível Superior. 

               3.5 O valor da taxa de inscrição por cargo fica firmado em: 

               Cargos Taxa de Inscrição 

               Nível Fundamental  R$ 85,00 (oitenta e cinco reais) 

               Nível Médio/Técnico R$ 120,00 (cento e vinte reais) 

               Nível Superior R$ 150,00 (cento e cinquenta reais) 

               3.6 O pagamento do valor correspondente à taxa de inscrição deverá ser efetuado até o dia 08 de agosto 
               de 2025, mediante, exclusivamente, boleto bancário gerado no ato da inscrição ou posteriormente na 
               Área do Candidato.  

               3.6.1 O pagamento do boleto poderá ser efetuado em qualquer agência bancária do território nacional 
               (observado o horário de funcionamento externo da agência) ou via internet (observado o horário 
               estabelecido pelo banco para quitação) até a data de 08 de agosto de 2025. 

               3.6.2 No caso de feriado ou interrupção de funcionamento dos serviços bancários, o pagamento da inscrição 
               deverá ser antecipado pelo candidato. 

               3.6.3 Não serão considerados pagamentos de inscrições realizados no último dia de vencimento após o 
               horário limite estabelecido pela instituição bancária, pois estes serão processados com data contábil 
               do próximo dia útil, bem como não serão aceitos pagamentos efetuados após a data prevista no item 
               3.6 deste Edital. 

               3.6.4 Não serão considerados os pagamentos realizados por meio de: depósito em caixa eletrônico, via 
               postal, PIX, transferência eletrônica, ordem de pagamento, depósito comum em conta corrente, 
               pagamento condicional, pagamento extemporâneo (ainda que realizado na data de vencimento, mas 
               após o horário limite definido pelo banco) ou qualquer outra forma não especificada neste Edital. Não 
               haverá restituição de valores nos casos de inobservância às regras previstas neste item. 

               3.7 Após efetuado o pagamento, o valor da taxa de inscrição não será restituído em hipótese alguma. 

               3.8 Não será permitida a transferência ou o aproveitamento do valor pago em uma inscrição para outra, 
               ainda que ambas sejam do mesmo candidato. 

               3.9 Após a efetivação do pagamento da taxa de inscrição, não será permitida, em hipótese alguma, a troca 
               de cargo. 

               3.9.1 Caso ainda não tenha efetuado o pagamento, o candidato que desejar se inscrever para outro cargo, 
               cuja prova ocorra no mesmo período, deverá cancelar a inscrição anterior antes de realizar uma nova. 

               3.9.2 Se o pagamento da taxa de inscrição já tiver sido realizado e o candidato desejar se inscrever para 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 3 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               outro cargo cuja prova ocorra no mesmo período, deverá, em até um dia útil antes do término do período 
               de inscrições, encaminhar solicitação ao e-mail concursopublico@furb.br, devidamente identificada 
               com seu nome completo e que contenha a solicitação de cancelamento da inscrição anterior, indicando 
               o cargo previamente escolhido. 

               3.10 A inscrição somente será considerada efetivada após a confirmação do pagamento da taxa de inscrição 
               ou o deferimento do pedido de isenção, ambos especificamente vinculados à inscrição e ao cargo 
               pretendido, e dentro dos prazos estabelecidos neste Edital. 

               3.11 O candidato que não recolher o valor da taxa de inscrição no prazo e na forma fixados neste Edital terá 
               a inscrição cancelada. 

               3.12 A declaração falsa ou inexata de dados constantes no formulário de inscrição e/ou a apresentação de 
               documentos falsos determinarão a anulação da inscrição e dos demais atos dela decorrentes. A FURB 
               reserva-se o direito de excluir do certame o candidato que fornecer dados inverídicos ou falsos. 

               3.13 Os candidatos que pretenderem, em caso de empate na classificação final, utilizar o benefício da Lei 
               Federal n.º 11.689/2008, previsto no item 17.2 deste Edital, e que exerceram efetivamente a função de 
               jurado no período após a data de publicação da Lei Federal n.º 11.689, de 09 de junho de 2008, deverão 
               informá-lo no ato de inscrição, bem como anexar documento comprobatório. 

               3.13.1 Para fins de comprovação, serão aceitos certidões, declarações, atestados ou outros documentos 
               públicos originais emitidos pelos Tribunais de Justiça Estaduais, do Distrito Federal e Regionais 
               Federais do País, relativos ao exercício da função de jurado, nos termos do art. 440 do Código de 
               Processo Penal, alterado pela Lei n.º 11.689/2008. 

               3.14 As informações prestadas no ato de inscrição são de inteira responsabilidade do candidato. 

               3.15 Ao realizar a sua inscrição, o candidato aceita que os seus dados pessoais sejam tratados e 
               processados de forma a permitir a efetiva execução do Concurso Público, autorizando expressamente 
               a divulgação do seu nome, número de inscrição, critérios de desempate e notas obtidas nas provas, 
               em observância aos princípios da publicidade e da transparência que regem a Administração Pública. 

               4 DAS VAGAS RESERVADAS PARA PESSOA COM DEFICIÊNCIA (PcD) 

               4.1 É considerada pessoa com deficiência, nos termos da Lei Federal n.º 13.146/2015, somente "aquela 
               que tem impedimento de longo prazo de natureza física, mental, intelectual ou sensorial, o qual, em 
               interação com uma ou mais barreiras, pode obstruir sua participação plena e efetiva na sociedade em 
               igualdade de condições com as demais pessoas", desde que a sua deficiência seja compatível com as 
               atribuições do cargo a que concorre. 

               4.2 Em cumprimento ao disposto na Lei Complementar n.º 53/2012, ficam reservadas 5% (cinco por cento) 
               das vagas a serem oferecidas para o cargo, ou das que vierem a surgir no prazo de sua validade, 
               destinadas aos candidatos com deficiência, desde que a deficiência seja compatível com as atribuições 
               do cargo para o qual concorrem. 

               4.3 A pessoa com deficiência, resguardadas as condições especiais previstas nesta Lei, participará do 
               concurso em igualdade de condições com os demais candidatos no que concerne ao conteúdo 
               programático das provas, à avaliação e ao critério de aprovação; ao horário e ao local de aplicação das 
               provas; à nota mínima exigida para todos os demais candidatos. 

               4.4 O candidato PcD – Pessoa com Deficiência que deseja concorrer às vagas a ele reservada deverá, 
               durante o período de inscrição, declarar ser pessoa com deficiência, escolher a modalidade de 
               concorrência como PcD – Pessoa com Deficiência e anexar o Laudo Médico que ateste a deficiência 
               permanente, seguindo as orientações da página. 

               4.4.1 O Laudo Médico deverá conter:  

               a) a identificação do candidato;  
               b) a assinatura, o carimbo e o CRM do médico responsável por sua emissão;  
               c) a espécie e o grau ou nível da deficiência, com expressa referência ao código correspondente da 

               Classificação Internacional de Doença – CID, bem como a causa da deficiência. 

               4.4.2 O Laudo Médico deve estar em um único arquivo no formato PDF, com suas páginas no tamanho A4, 
               com tamanho máximo de 20MB, com resolução que permita a perfeita leitura do conteúdo.  

               4.4.3 Não serão considerados os documentos ilegíveis, com rasuras ou emendas, nem os que não atendam 
               às especificações contidas neste Edital. 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 4 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               4.4.4 Não haverá, em hipótese alguma, outra data, horário ou forma para a entrega do Laudo Médico. 

               4.5 Na hipótese de não haver número de candidatos com deficiência aprovados suficiente para ocupar as 
               vagas reservadas, as vagas remanescentes serão revertidas para a ampla concorrência e serão 
               preenchidas pelos demais candidatos aprovados, observada a ordem de classificação. 

               4.6 Os candidatos que não atenderem aos dispositivos mencionados no item 4.4 deste Edital, seja qual for 
               o motivo alegado, serão considerados como pessoas sem deficiência, concorrerão na modalidade de 
               ampla concorrência, bem como poderão não ter as condições especiais atendidas. 

               4.7 No ato de inscrição, o candidato com deficiência declara estar ciente das atribuições do cargo público 
               para o qual se inscreve e que, no caso de vir a exercê-lo, estará sujeito à avaliação pelo desempenho 
               dessas atribuições.  

               4.8 O candidato com deficiência que não realizar a inscrição, conforme instruções constantes neste Edital, 
               não poderá interpor recurso em favor de sua situação. 

               4.9 O candidato com deficiência que necessite de condições especiais para realização da prova deverá 
               requerê-las, indicando sua necessidade, conforme prazos e condições previstas no item 13 deste 
               Edital. 

               4.10 O candidato com deficiência que necessitar de tempo adicional poderá ter, no máximo, mais 60 minutos 
               para realização da prova objetiva e deverá requerê-lo, com justificativa acompanhada de parecer 
               emitido por especialista da área de sua deficiência, conforme item 13.1 deste Edital. 

               4.11 O candidato com deficiência, se classificado, figurará na lista de classificação geral por opção de cargo, 
               e na lista específica de candidatos com deficiência, por opção de cargo. 

               4.12 O candidato que se declarar com deficiência, caso convocado no Concurso Público, será submetido à 
               avaliação da Junta Médica Funcional do Município, conforme Decreto Federal n.º 3.298/99 e Decreto 
               Federal n.º 5.296/04, que terá a decisão terminativa sobre: a qualificação do candidato como deficiente 
               ou não; e o grau de deficiência, capacitado ou não para o exercício do cargo. 

               4.12.1 Será eliminado da lista de candidatos que concorrem às vagas reservadas o candidato que não atender 
               à convocação para comparecer à avaliação perante da Junta Médica Funcional do Município e/ou cuja 
               condição assinalada no requerimento de inscrição não seja constatada, passando a compor apenas a 
               lista de classificação de ampla concorrência. 

               4.13 A banca especializada deliberará sobre o pedido de vaga PcD com base na legislação vigente e a 
               relação dos pedidos deferidos e indeferidos será publicado no dia 11 de agosto de 2025, no endereço 
               eletrônico http://concursos.furb.br em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025, cabendo 
               recurso do indeferimento, conforme procedimentos e normas previstas no item 21 deste Edital. 

               4.14 Em caso de não confirmação da deficiência declarada ou da não compatibilidade da deficiência com 
               as atribuições da função, importará a perda do direito ao pleito da vaga reservada à PcD, passando a 
               compor apenas a lista de classificação de ampla concorrência.  

               5 DAS ISENÇÕES DE PAGAMENTO DO VALOR DE INSCRIÇÃO 

               5.1 O candidato poderá requerer isenção do pagamento da taxa de inscrição após a efetivação de sua 
               inscrição, por meio do endereço eletrônico http://concursos.furb.br, na opção "Solicitar Isenção", 
               disponível na Área do Candidato. O pedido de isenção deverá ser feito por cargo, seguindo as 
               orientações da página, e deverá estar acompanhado dos documentos comprobatórios exigidos pela 
               legislação vigente, no período compreendido entre 8h do dia 07 de julho de 2025 e 23h59min do dia 
               16 de julho de 2025, conforme orientações a seguir. 

               5.2 Poderão solicitar a isenção do pagamento da taxa de inscrição, os candidatos que comprovarem um 
               dos seguintes requisitos: 

               a) ser doador de sangue, nos termos da Lei Ordinária Municipal n.º 2.437/2007; 
               b) ser doador de medula óssea, nos termos da Lei Ordinária Municipal n.º 3.805/2017 e suas 

               alterações; 
               c) ser doadora de leite materno, nos termos da Lei Ordinária Municipal n.º 4.094/2022; 
               d) ser pessoa com deficiência, nos termos da Lei Ordinária Municipal n.º 2.455/2007. 

               5.2.1 Para usufruir do benefício da isenção do valor da taxa previsto na alínea “a”, o candidato doador de 
               sangue deverá anexar documento expedido pela entidade coletora, emitido por órgão oficial ou 
               entidade credenciada pela União, pelo Estado ou por Município, contendo o nome completo do doador, 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 5 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               bem como a discriminação do número e das datas em que foram realizadas as doações, não podendo 
               ser inferior a 03 (três) vezes anuais, no período de 365 (trezentos e sessenta e cinco) dias 
               imediatamente anteriores à publicação deste Edital. 

               5.2.2 Para usufruir do benefício da isenção do valor da taxa previsto na alínea “b”, o candidato regularmente 
               cadastrado como doador de medula óssea em entidades reconhecidas pelo Ministério da Saúde, 
               deverá anexar documento comprobatório que comprove cadastro no Registro Nacional de Doadores 
               Voluntários de Medula Óssea (REDOME). 

               5.2.3 Para usufruir do benefício da isenção do valor da taxa previsto na alínea “c”, a candidata doadora de 
               leite materno deverá anexar documento expedido por entidade coletora, vinculada a órgão oficial ou 
               credenciada pela União, Estado ou Município que comprove a realização de, no mínimo, 3 (três) 
               doações no período de 365 (trezentos e sessenta e cinco) dias imediatamente anteriores à publicação 
               deste Edital. 

               5.2.4 Para usufruir do benefício da isenção do valor da taxa previsto na alínea “d”, o candidato PcD – Pessoa 
               com Deficiência deverá anexar, em um único arquivo, atestado médico fornecido por profissional 
               cadastrado junto ao Sistema Único de Saúde - SUS, bem como a Carteira de Identidade. 

               5.2.5 O documento comprobatório deve estar em um único arquivo no formato PDF, com suas páginas no 
               tamanho A4, com tamanho máximo de 20MB e com resolução que permita a perfeita leitura do 
               conteúdo. 

               5.3 A documentação mencionada no item 5.2.4 será utilizada exclusivamente para análise do pedido de 
               isenção da taxa de inscrição. Para concorrer às vagas reservadas às pessoas com deficiência, o 
               candidato deverá observar o disposto no item 4 deste Edital. 

               5.4 Não haverá, em hipótese alguma, outra data, horário ou forma para a entrega dos documentos 
               comprobatórios previstos neste Edital. 

               5.5 Não será considerado o documento ilegível, com rasuras ou emendas, nem o que não atenda às 
               especificações contidas neste Edital. 

               5.6 A resposta aos pedidos de isenção da taxa de inscrição será publicada no dia 28 de julho de 2025, no 
               endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025, 
               cabendo recurso do indeferimento, conforme procedimentos e normas previstas no item 21 deste Edital. 

               5.7 O candidato cujo pedido de isenção for indeferido definitivamente poderá, caso queira, efetuar o 
               pagamento do valor da taxa de inscrição até o prazo final das inscrições de acordo com o item 3.6 
               deste Edital. 

               5.8 O não cumprimento de qualquer um dos itens referentes à isenção de pagamento da inscrição 
               implicará, automaticamente, o cancelamento de seu pedido de isenção. 

               6 DA HOMOLOGAÇÃO DAS INSCRIÇÕES 

               6.1 A relação dos candidatos que tiverem a inscrição deferida será divulgada no dia 11 de agosto de 2025, 
               no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 
               001/2025, cabendo recurso do indeferimento, conforme procedimentos e normas previstas no item 21 
               deste Edital. 

               6.2 A homologação das inscrições será publicada no dia 18 de agosto de 2025, no endereço eletrônico 
               http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025. 

               7 DA RETIFICAÇÃO DOS DADOS CADASTRAIS 

               7.1 Os eventuais erros de digitação de informações pessoais ocorridos quando da inscrição deverão ser 
               corrigidos exclusivamente pelo candidato no endereço eletrônico http://concursos.furb.br/, por meio da 
               opção “Meus Dados”, disponível na Área do Candidato, seguindo as orientações da página. 

               7.2 A correção dos dados deverá ser efetuada nos prazos limites indicados a seguir, conforme a 
               qualificação da informação a ser alterada:  

               a) Nome: até 1 (um) dia antes da data prevista para publicação das inscrições deferidas; 
               b) Documentos de Identificação (exceto CPF): até 7 (sete) dias antes da data prevista para a realização 

               da Prova Objetiva; 
               c) Data de Nascimento: até 3 (três) dias após a realização da Prova Objetiva; 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 6 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               d) Existência de Deficiências: até o prazo final para a realização das inscrições; 
               e) Endereços, meios de comunicação e informações complementares (que não influenciam na fase 

               competitiva do certame): até 1 (um) dia após a publicação do resultado final. 

               7.3 Os prazos estipulados representam os limites aceitáveis para a manutenção da publicidade e da 
               competitividade do certame, ficando a FURB isenta de qualquer responsabilidade sobre as 
               consequências geradas pela informação incorreta até a data efetiva da correção. 

               7.4 O candidato que não realizar as correções dos dados será o único responsável pelas consequências 
               advindas de sua omissão. 

               8 DAS ETAPAS DO CONCURSO PÚBLICO 

               8.1 O Concurso Público será composto por:  

               a) Prova Objetiva: de caráter classificatório e eliminatório para todos os cargos, conforme o item 9 
               deste Edital; e  

               b) Prova Prática de caráter classificatório e eliminatório somente para os cargos de Motorista I - 
               Veículos Leves, Motorista II - Veículos Leves e Utilitários, Motorista IV – Caminhões, Operador de 
               Máquinas e Equipamentos Pesados, Operador de Patrola, Operador de Retroescavadeira e 
               Operador de Trator Agrícola, conforme o item 18 deste Edital. 

               8.2 As provas serão realizadas preferencialmente no município de Biguaçu/SC, conforme definido pela 
               FURB e Comissão do Concurso Público e publicado no endereço eletrônico http://concursos.furb.br, 
               em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025. Havendo indisponibilidade de locais 
               suficientes ou adequados no Município, as provas poderão ser realizadas em instituições de ensino 
               dos municípios da região. 

               8.3 As despesas de deslocamento, estadia, preparação, obtenção de documentação, etc., efetuadas pelos 
               candidatos em razão deste certame, independentemente das circunstâncias, são de única e exclusiva 
               responsabilidade dos candidatos, não cabendo quaisquer alegações de prejuízo e/ou solicitações de 
               ressarcimento. 

               9 DA PROVA OBJETIVA 

               9.1 A Prova Objetiva tem caráter classificatório e eliminatório para todos os cargos, com questões objetivas, 
               de múltipla escolha, com cinco alternativas cada e apenas uma alternativa correta. As questões 
               objetivas serão distribuídas conforme os itens 9.1.1, 9.1.2 e 9.1.3 deste Edital. 

               9.1.1 Para os cargos de nível Fundamental, a prova objetiva conterá 30 (trinta) questões: 

               PROVA OBJETIVA – NÍVEL FUNDAMENTAL 
               N.º DE VALOR DA 

               ÁREA DE CONHECIMENTO TOTAL 
               QUESTÕES QUESTÃO 

               LÍNGUA PORTUGUESA 10 0,30 3,00 
               RACIOCÍNIO LÓGICO 05 0,20 1,00 
               CONHECIMENTOS ESPECÍFICOS 15 0,40 6,00 

               VALOR TOTAL DA PROVA OBJETIVA 30 - 10,00 

               9.1.2 Para os cargos de nível Médio/Técnico, a prova objetiva conterá 40 (quarenta) questões: 

               PROVA OBJETIVA – NÍVEL MÉDIO/TÉCNICO 
               N.º DE VALOR DA 

               ÁREA DE CONHECIMENTO TOTAL 
               QUESTÕES QUESTÃO 

               LÍNGUA PORTUGUESA 10 0,20 2,00 
               RACIOCÍNIO LÓGICO 05 0,20 1,00 
               NOÇÕES DE INFORMÁTICA 05 0,20 1,00 
               CONHECIMENTOS ESPECÍFICOS 20 0,30 6,00 

               VALOR TOTAL DA PROVA OBJETIVA 40 - 10,00 

               9.1.3 Para os cargos de nível Superior, a prova objetiva conterá 50 (cinquenta) questões: 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 7 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               PROVA OBJETIVA – NÍVEL SUPERIOR 
               N.º DE VALOR DA 

               ÁREA DE CONHECIMENTO TOTAL 
               QUESTÕES QUESTÃO 

               LÍNGUA PORTUGUESA 10 0,14 1,40 
               RACIOCÍNIO LÓGICO 05 0,14 0,70 
               NOÇÕES DE INFORMÁTICA 05 0,14 0,70 
               CONHECIMENTOS ESPECÍFICOS 30 0,24 7,20 

               VALOR TOTAL DA PROVA OBJETIVA 50 - 10,00 

               9.2 O conteúdo programático é o constante nos Anexos III, IV, V e VI deste Edital.  

               9.3 A Prova Objetiva será avaliada na escala de 0,00 (zero) a 10,00 (dez) pontos, devendo o candidato 
               obter no mínimo 5,00 (cinco) pontos para ser considerado como aprovado na Prova Objetiva.  

               9.4 Os locais e as salas da prova serão publicados no dia 20 de agosto de 2025, no endereço eletrônico 
               http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025. 

               9.5 A Prova Objetiva será realizada no dia 31 de agosto de 2025, conforme o cronograma a seguir: 

               9.5.1 Para os cargos de nível Fundamental, com duração de 2 (duas) horas e 30 (trinta) minutos: 

               EVENTO HORÁRIO 

               Abertura do local de realização da prova 8h10min00seg 
               Fechamento do local de realização da prova  9h00min00seg 
               Início da prova objetiva 9h10min00seg 
               Permitida a entrega do material de prova e saída do local 10h10min00seg 
               Término da prova objetiva 11h40min00seg 

               9.5.2 Para os cargos de nível Médio/Técnico, com duração de 3 (três) horas: 

               EVENTO HORÁRIO 

               Abertura do local de realização da prova 8h10min00seg 
               Fechamento do local de realização da prova  9h00min00seg 
               Início da prova objetiva 9h10min00seg 
               Permitida a entrega do material de prova e saída do local 10h10min00seg 
               Término da prova objetiva 12h10min00seg 

               9.5.3 Para os cargos de nível Superior, com duração de 3 (três) horas e 30 (trinta) minutos: 

               EVENTO HORÁRIO 

               Abertura do local de realização da prova 14h10min00seg 
               Fechamento do local de realização da prova  15h00min00seg 
               Início da prova objetiva 15h10min00seg 
               Permitida a entrega do material de prova e saída do local 16h10min00seg 
               Término da prova objetiva 18h40min00seg 

               9.5.4 Os locais onde serão realizados os dois blocos da será realizada a [errata n.º 02] Prova Objetiva serão 
               fechados, impreterivelmente, no horário marcado nos quadros dos itens 9.5.1, 9.5.2 e 9.5.3 deste Edital. 
               Recomenda-se ao candidato chegar ao local da prova com antecedência mínima de 30 (trinta) minutos 
               do horário estabelecido. 

               9.5.5 É responsabilidade exclusiva do candidato informar-se sobre o local de realização da prova e seu 
               horário.  

               9.5.6 O candidato que chegar ao local da prova após o fechamento do acesso terá sua entrada vedada e 
               será automaticamente eliminado do Concurso Público. Não haverá segunda chamada, seja qual for o 
               motivo alegado para justificar o atraso ou a ausência do candidato. 

               9.6 A FURB reserva-se o direito de transferir a data de aplicação da prova ou de atrasar o horário de início, 
               por motivos fortuitos ou de força maior, tais como enchentes, perturbações da ordem pública ou 
               situações que impactem diretamente na segurança das pessoas ou no acesso ao local de prova, dando 
               ciência aos candidatos pelo e-mail cadastrado no formulário de inscrição e por informativo no endereço 
               eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025, ou ainda, 
               eventualmente, presencialmente no local de prova. 

               9.7 Havendo alteração da data prevista, a Prova Objetiva poderá ocorrer em dias de semana, domingos 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 8 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               ou feriados nacionais.  

               9.8 Em hipótese nenhuma será realizada prova fora do local, data e horário determinados neste Edital e 
               na confirmação do local de provas, exceto em hipótese prevista no item 9.6 deste Edital. 

               9.9 A emissão da declaração de comparecimento da Prova Objetiva somente será efetuada no dia da 
               aplicação. Após terminar a prova, o candidato deverá procurar a coordenação de aplicação do seu local 
               de prova para solicitá-la.  

               10 DAS NORMAS DA PROVA OBJETIVA 

               10.1 O candidato somente terá acesso à sala de realização da Prova Objetiva mediante a apresentação de 
               um dos documentos de identidade oficial original, conforme item 11 deste Edital.  

               10.2 O acesso às salas de prova por pessoas estranhas somente será permitido mediante a autorização da 
               Coordenação. 

               10.3 Para realização da prova, o candidato deverá levar caneta de tinta azul ou preta, fabricada em material 
               transparente, que será de uso exclusivo dele. 

               10.4 Durante a realização das provas, é permitida posse e uso unicamente dos seguintes materiais: 

               a) documento de identidade oficial original, conforme item 11 deste Edital;  
               b) caneta fabricada em material transparente com tinta azul ou preta; 
               c) caso deseje, água e/ou alimento deverão estar lacrados ou acondicionados em embalagem plástica 

               transparente. 

               10.5 É vedado ao candidato permanecer no local de realização da prova com quaisquer tipos de aparelhos 
               eletrônicos ou de comunicação (bipe, pager, telefone celular, qualquer tipo de relógio, agenda 
               eletrônica, notebook, palmtop, receptor, gravador, calculadora, controle remoto, alarme de carro) ou 
               com quaisquer outros componentes ou equipamentos eletrônicos em funcionamento ou não. Também 
               é proibido fumo e o uso de medicamentos, óculos escuros, boné, gorro, chapéu ou similares sem 
               solicitação e autorização, conforme previsto no item 13.1 deste Edital. 

               10.6 O candidato que estiver portando algum item não permitido, no início da prova, deverá informar ao fiscal 
               da sala, que fornecerá um envelope porta objetos, o qual deverá permanecer lacrado durante todo o 
               período da prova, sob a guarda do candidato. 

               10.7 O candidato que se negar à identificação ou a se submeter ao detector de metais terá a sua prova 
               anulada e, com isso, será eliminado do Concurso Público. 

               10.8 Não haverá funcionamento de guarda-volumes nos locais de realização da prova e a FURB não se 
               responsabilizará por perda ou extravio de objetos ou equipamentos eletrônicos ocorridos durante a 
               realização da prova, tampouco por danos neles causados. 

               10.9 O candidato que necessitar se ausentar da sala de provas durante sua realização somente poderá 
               fazê-lo acompanhado de um fiscal. 

               10.10 Não haverá, por qualquer motivo, prorrogação do tempo previsto para a aplicação da prova em virtude 
               de afastamento do candidato da sala de prova. 

               10.11 O candidato não poderá se ausentar da sala de prova, a qualquer tempo, portando o Caderno de 
               Questões e o Cartão-Resposta. 

               10.12 Ao terminar a prova, o candidato deverá entregar ao fiscal de sala o Caderno de Questões e o Cartão-
               Resposta devidamente preenchidos e assinados. 

               10.12.1 Será permitido ao candidato levar apenas a folha intermediária de respostas, localizada na última 
               página do Caderno de Questões, desde que contenha exclusivamente as alternativas assinaladas, 
               vedadas quaisquer outras anotações. 

               10.13 Os 3 (três) últimos candidatos de cada sala de prova somente poderão se retirar da sala 
               simultaneamente. 

               11 DA DOCUMENTAÇÃO EXIGIDA PARA REALIZAÇÃO DA PROVA 

               11.1 Para fins de acesso ao local de realização das provas, somente será aceito como documento de 
               identidade oficial original: 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 9 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               a) a Carteira de Identidade expedida pelas Secretarias de Segurança, pelas Forças Armadas, pela 
               Polícia Militar ou pelo Ministério das Relações Exteriores; 

               b) a Carteira Nacional de Habilitação; 
               c) a Carteira de Identidade Profissional fornecida por Órgãos Competentes; 
               d) o Passaporte; 
               e) a Carteira de Trabalho e Previdência Social. 

               11.1.1 O documento deverá estar em perfeitas condições e com foto recente, de forma a permitir a 
               identificação do candidato com clareza. 

               11.2 Não serão aceitos para fins de acesso ao local de realização da prova: Boletim de Ocorrência; Protocolo 
               de segunda via; Cópia de Documentos Oficiais, mesmo que autenticadas; Certidão de Nascimento; 
               Título Eleitoral; Carteira Nacional de Habilitação (emitida antes da Lei n.º 9.503/1997); Carteira de 
               Estudante; Crachás e Identidade Funcional de natureza pública ou privada; a Carteira de Trabalho 
               Digital; documentos digitais de identidade oficial apresentados fora de seus aplicativos oficiais. 

               12 DO CADERNO DE QUESTÕES E DO CARTÃO-RESPOSTA 

               12.1 Para a realização da Prova Objetiva, o candidato receberá o Caderno de Questões e o Cartão-Resposta 
               personalizado. 

               12.2 Distribuídos os cadernos de questões aos candidatos e, na hipótese de serem verificadas falhas de 
               impressão, o coordenador do local de prova, antes do início da prova, diligenciará no sentido de 
               substituir os cadernos de questões com defeito. 

               12.2.1 Se a ocorrência for verificada após o início da prova, o fiscal da sala, depois de ouvida a Coordenação 
               do Concurso Público, estabelecerá prazo para compensação do tempo usado para regularização do 
               caderno. 

               12.3 O candidato deverá responder às questões e transcrever as respostas para o Cartão-Resposta 
               personalizado.  

               12.4 A avaliação das provas far-se-á, exclusivamente, por meio de Cartão-Resposta personalizado, o que 
               anula qualquer outra forma de avaliação. 

               12.5 O Cartão-Resposta personalizado deverá ser assinado no local designado e os círculos reservados 
               para as respostas deverão ser preenchidos com caneta esferográfica fabricada em material 
               transparente, com tinta azul ou preta, seguindo as orientações nele contidas.  

               12.6 O preenchimento do Cartão-Resposta personalizado será de inteira responsabilidade do candidato, 
               que deverá proceder em conformidade com as instruções nele constantes. Em hipótese alguma haverá 
               substituição do Cartão-Resposta personalizado em caso de marcação errada ou de rasura. 

               12.7 O candidato será o único responsável pelos prejuízos advindos de marcações incorretas ou de danos 
               ao Cartão-Resposta personalizado. 

               12.8 Não será computada questão com emenda, rasura ou preenchida a lápis, ainda que legível, nem 
               questão não respondida ou que contenha mais de uma resposta, mesmo que uma delas esteja correta. 

               12.9 Não deverá ser feita nenhuma marca fora do campo reservado às respostas ou à assinatura, uma vez 
               que qualquer marca poderá ser identificada pelas leitoras, prejudicando o desempenho do candidato. 

               12.10 Por razões de ordem técnica, de segurança e de direitos autorais adquiridos, a FURB não fornecerá 
               exemplares dos Cadernos de Questões a candidatos ou a instituições de direito público ou privado, 
               mesmo após o encerramento do Concurso Público. As questões das provas e respectivos gabaritos 
               serão publicados somente pela internet, no endereço eletrônico http://concursos.furb.br, em Prefeitura 
               Municipal de Biguaçu - Edital n.º 001/2025. 

               12.11 A FURB reserva-se o direito de manter os Cartões-Resposta personalizados e os Cadernos de 
               Questões das provas por um período de 120 (cento e vinte) dias a contar da divulgação do resultado 
               do Concurso Público. Após esse período o material será destruído. 

               13 DA CONDIÇÃO ESPECIAL PARA REALIZAÇÃO DA PROVA 

               13.1 O candidato que necessitar de “condições especiais para a realização da prova objetiva” deverá 
               solicitá-las, durante o período de inscrição, por meio do endereço eletrônico http://concursos.furb.br/ na 
               Área do Candidato, seguindo as orientações da página. 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 10 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               13.2 A candidata lactante deverá encaminhar junto à solicitação a certidão de nascimento do bebê, sendo 
               que, durante a realização da prova: 

               a) não haverá compensação do tempo de amamentação em favor da candidata;  
               b) a criança deverá ser acompanhada, em ambiente reservado para este fim, de adulto responsável 

               por sua guarda (familiar ou terceiro indicado pela candidata); 
               c) nos horários previstos para amamentação, a candidata lactante poderá se ausentar 

               temporariamente da sala de prova, acompanhada de uma fiscal; 
               d) na sala reservada para amamentação, ficará somente a candidata lactante, a criança e uma fiscal, 

               sendo vedada a permanência de babás ou quaisquer outras pessoas que tenham grau de 
               parentesco ou de amizade com a candidata; 

               e) o acompanhante e o bebê entram no local de prova no mesmo horário dos candidatos. 

               13.3 O candidato que, em razão de crença ou convicção religiosa, adote o uso de adornos ou indumentárias 
               (kipá, turbante, véu, entre outros) deverá requerer esse uso conforme o item 13.1 deste Edital. Nesse 
               caso, poderá ser submetido, no dia da prova, ao detector de metais, caso necessário. 

               13.4 A solicitação de tratamento especial para realização da prova deverá ser prévia, respeitados os critérios 
               de razoabilidade. 

               13.5 O atendimento às condições solicitadas ficará sujeito à análise da legalidade e razoabilidade do pedido. 

               13.6 Somente serão apreciadas as solicitações de condições especiais que contenham pedidos 
               determinados e que apontarem as circunstâncias pertinentes que os justifiquem. 

               13.7 O candidato que não atender às normas estabelecidas neste Edital não terá o atendimento à condição 
               especial para a realização das provas, não podendo impetrar recurso em favor de sua condição. 

               13.8 A relação dos pedidos de condições especiais para realização da prova objetiva será publicada no dia 
               11 de agosto de 2025, no endereço eletrônico http://concursos.furb.br em Prefeitura Municipal de 
               Biguaçu - Edital n.º 001/2025, cabendo recurso do indeferimento, conforme procedimentos e normas 
               previstas no item 21 deste Edital. 

               13.9 Se a ocorrência para condição especial para realização da prova se der após o prazo de inscrição, o 
               candidato poderá encaminhar a solicitação para o e-mail concursopublico@furb.br, anexando laudo 
               médico, no prazo de até 72h antes do horário marcado para o início da prova. 

               14 DA SEGURANÇA DO CONCURSO PÚBLICO 

               14.1 A FURB, objetivando garantir a lisura, a autenticidade e a idoneidade do Concurso Público e zelando 
               pelo interesse público, em especial, dos candidatos, poderá solicitar, quando da aplicação da prova, a 
               autenticação digital do candidato em formulário específico. 

               14.2 Na hipótese de o candidato recusar-se a fazê-la ou se, por qualquer motivo, não for possível essa forma 
               de identificação, deverá registrar sua assinatura, em campo específico, por três vezes. 

               14.3 A qualquer tempo, durante a realização da Prova Objetiva, o candidato poderá ser submetido ao 
               detector de metais, sob pena de eliminação do Concurso Público. 

               14.4 Medidas adicionais de segurança poderão ser adotadas. 

               14.5 É de inteira responsabilidade do candidato qualquer transtorno por ele ocasionado.  

               14.6 Caso seja constatado, por qualquer meio, que o candidato utilizou procedimentos ilícitos durante a 
               realização da prova, a FURB anulará a prova do candidato infrator, eliminando-o do Concurso Público. 

               15 DA ELIMINAÇÃO DO CANDIDATO 

               15.1 Motivará a eliminação do candidato, sem prejuízo das sanções penais cabíveis, a burla ou a tentativa 
               de burla a quaisquer das normas definidas neste Edital ou a outras relativas ao Concurso Público, aos 
               comunicados, às instruções ao candidato ou às instruções constantes do Caderno de Questões. 

               15.2 Será eliminado do Concurso Público o candidato que: 

               a) apresentar-se após o horário estabelecido para a realização das provas, inadmitindo-se qualquer 
               tolerância; 

               b) não comparecer às provas, qualquer que seja o motivo alegado; 
               c) não apresentar documento que bem o identifique, de acordo com o item 11, deste Edital; 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 11 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               d) negar-se a realizar as provas; 
               e) ausentar-se da sala de prova sem o acompanhamento do fiscal ou antes de decorrida 1 (uma) hora 

               do início da Prova Objetiva; 
               f) fizer quaisquer anotações de informações relativas às questões ou respostas, exceto a marcação 

               do campo específico reservado na Folha Intermediária de Respostas na Prova Objetiva; 
               g) ausentar-se da sala da Prova Objetiva levando o Cartão-Resposta personalizado ou o Caderno de 

               Questões ou outros materiais não permitidos, sem autorização; 
               h) estiver portando armas, mesmo que possua o respectivo porte; 
               i) utilizar-se de meios ilícitos para a execução das provas; 
               j) não devolver integralmente o material recebido, exceto a Folha Intermediária de Respostas na Prova 

               Objetiva; 
               k) for surpreendido, durante a realização das provas, em comunicação com outros candidatos, fazendo 

               qualquer espécie de consulta em livros, códigos, manuais, impressos ou quaisquer anotações, ou 
               utilizando máquina calculadora;  

               l) usar ou for encontrado de posse de qualquer tipo de aparelho eletrônico ou de comunicação (bip, 
               pager, telefone celular, qualquer tipo de relógio, agenda eletrônica, notebook, palmtop, receptor, 
               gravador, calculadora, controle remoto, alarme de carro) ou quaisquer outros componentes ou 
               equipamentos eletrônicos em funcionamento ou não, bem como protetores auriculares; 

               m) estiver utilizando boné, gorro, chapéu ou similares, óculos escuros, aparelho auricular, sem a devida 
               autorização, conforme item 13.3 deste Edital; 

               n) tratar incorretamente ou agir com descortesia em relação a qualquer pessoa envolvida na aplicação 
               das provas, bem como aos Coordenadores e seus Auxiliares ou Autoridades presentes. 

               16 DA PUBLICAÇÃO DOS GABARITOS E DAS PROVAS 

               16.1 O inteiro teor da prova e o gabarito preliminar da Prova Objetiva serão divulgados até às 20h do dia 
               01 de setembro de 2025, no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de 
               Biguaçu - Edital n.º 001/2025, cabendo recurso, conforme procedimentos e normas previstas no item 
               21 deste Edital. 

               16.2 O Gabarito Oficial e o resultado da Prova Objetiva serão divulgados no dia 18 de setembro de 2025, 
               no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 
               001/2025. 

               16.3 No dia 18 de setembro de 2025 será disponibilizada a imagem digitalizada do Cartão-Resposta para 
               consulta individual na Área do Candidato. 

               17 DOS CRITÉRIOS DE DESEMPATE 

               17.1 Ocorrendo empate na classificação dos candidatos, aplicar‐se‐á, para o desempate, o disposto no 
               parágrafo único do Art. 27 da Lei Federal n.º 10.741/2003, para os candidatos que se enquadrarem na 
               condição de idoso nos termos do Art. 1º da mencionada Lei (possuírem 60 anos completos ou mais no 
               último dia de inscrições do concurso). 

               17.2 Para os candidatos que não estão sob o amparo do item anterior, o desempate beneficiará, 
               sucessivamente, o candidato que tenha: 

               a) maior número de acertos nas questões de Conhecimentos Específicos; 
               b) maior número de acertos nas questões de Língua Portuguesa; 
               c) maior número de acertos nas questões de Noções de Informática, se houver; 
               d) maior número de acertos nas questões de Raciocínio Lógico,  
               e) exercido a função de jurado (Lei n.º 11.689/2008); 
               f) maior idade. 

               18 PROVA PRÁTICA 

               18.1 A Prova Prática, de caráter classificatório e eliminatório, será realizada somente para os candidatos 
               aos cargos de Motorista I – Veículos Leves; Motorista II – Veículos Leves e Utilitários; Motorista IV – 
               Caminhões; Operador de Máquinas e Equipamentos Pesados; Operador de Patrola; Operador de 
               Retroescavadeira; e Operador de Trator Agrícola, que forem aprovados na Prova Objetiva, conforme 
               classificação a seguir: 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 12 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               CONVOCADOS PARA A PROVA PRÁTICA 

               Vagas  Vagas  Total de  
               Cargo 

               Ampla Concorrência Reservadas PcD Convocados 

               Motorista I – Veículos Leves 71 04 75 

               Motorista II – Veículos Leves e 
               28 02 30 

               Utilitários 

               Motorista IV – Caminhões 14 01 15 

               Operador de Máquinas e 
               14 01 15 

               Equipamentos Pesados 

               Operador de Patrola 14 01 15 

               Operador de Retroescavadeira 14 01 15 

               Operador de Trator Agrícola 14 01 15 

               18.1.1 Ocorrendo empate entre candidatos classificados para a Prova Prática, serão aplicados os critérios de 
               desempate descritos no item 17 deste Edital. 

               18.1.2 Não havendo número suficiente de candidatos classificados para as vagas reservadas às pessoas com 
               deficiência, as vagas remanescentes serão preenchidas pelos candidatos classificados na ampla 
               concorrência, observada a ordem de classificação, até o limite máximo estabelecido para a 
               convocação. 

               18.2 A relação dos candidatos convocados para a realização da Prova Prática, bem como o local e o horário 
               serão divulgados no dia 18 de setembro de 2025, no endereço eletrônico http://concursos.furb.br, em 
               Prefeitura Municipal de Biguaçu - Edital n.º 001/2025. 

               18.3 A Prova Prática será realizada no dia 28 de setembro de 2025.  

               18.4 É responsabilidade exclusiva do candidato informar-se sobre o local de realização da prova e seu 
               horário. 

               18.5 Em hipótese nenhuma será realizada qualquer prova em outra data ou fora do local, sala e horário 
               determinados na Convocação para a Prova Prática, seja qual for o motivo alegado. O candidato não 
               poderá alegar qualquer desconhecimento sobre a realização da prova como justificativa de ausência 
               ou atraso. O não comparecimento ou atraso, por qualquer que seja o motivo, impedirá o acesso do 
               candidato ao local da prova e caracterizará desistência, resultando na eliminação do Concurso. 

               18.6 Para realizarem a Prova Prática, todos os candidatos convocados deverão se apresentar para 
               identificação, chamada e instruções na data, local e horário publicados. 

               18.7 Recomenda-se aos candidatos chegarem ao local da prova com antecedência mínima de 30 (trinta) 
               minutos do horário estabelecido, munidos do documento de identidade oficial original, conforme item 
               11 deste Edital. 

               18.7.1 Para realizar a prova, o candidato deverá apresentar carteira de habilitação original, conforme os 
               requisitos no Anexo I deste edital, a qual deverá ter sido obtida ou renovada até a data da realização 
               da Prova Prática, sem a qual não poderá realizar a prova. 

               18.7.2 Não serão aceitos certificados de autoescola, comprovantes de encaminhamento ou outro documento 
               que não seja a carteira de habilitação. 

               18.7.3 Caso o candidato demonstre conhecimento insuficiente ou insegurança, oferecendo qualquer tipo de 
               risco na operação, será impedido de realizar a prova e considerado desclassificado e eliminado do 
               Concurso Público. 

               18.8 Os candidatos serão chamados por ordem alfabética, devendo assinar a lista de presença. Após a 
               identificação, os candidatos receberão as instruções quanto à prova e permanecerão à espera do fiscal 
               que lhes acompanhará até o local de realização da prova. Os candidatos deverão ficar em sala de 
               espera, não podendo fazer uso de qualquer material de consulta, tais como, apostilas, livros, anotações, 
               celular, tablet, notebook ou qualquer outro aparelho eletrônico, sob pena de eliminação do Concurso 
               Público. 

               18.8.1 O candidato, ao assinar a lista de presença da Prova Prática, atestará terem sido cumpridas todas as 
               normas editalícias. 

               18.9 Em razão de condições climáticas, a critério da Banca Examinadora e da Comissão de Concurso, a 
               Prova Prática dos cargos de Operador poderá ser cancelada ou interrompida. Em caso de adiamento 
               da prova, a nova data será marcada e divulgada por meio do endereço eletrônico 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 13 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               http://concursos.furb.br/, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025. 

               18.10 Haverá um tempo máximo para a realização de cada item da prova, informado pelo avaliador, 
               considerando a dificuldade e demais aspectos necessários para o desempenho satisfatório dos testes, 
               por parte dos candidatos. 

               18.11 No critério da eficiência (para a realização das provas práticas), as tarefas a serem executadas pelos 
               candidatos serão idênticas, avaliando-se quem terá realizado a tarefa toda, ou a maior quantidade em 
               relação ao tempo pré-estabelecido ou em menor tempo, com a mesma qualidade. 

               18.12 Os casos de alterações psicológicas ou fisiológicas (contusões, luxações, entre outras) que 
               impossibilitem o candidato de submeter-se às tarefas da prova, ou de nelas prosseguir, ou que lhe 
               diminuam a capacidade físico-orgânica, não serão considerados para fins de tratamento diferenciado 
               ou para repetir a prova e nem lhe conferem o direito de realizar a prova em outra oportunidade. 

               18.13 No desenvolvimento da Prova Prática, cada candidato será avaliado pela Banca Examinadora por meio 
               de itens constantes em uma planilha de avaliação elaborada para esta finalidade. 

               18.14 O candidato deverá executar atividades inerentes ao cargo, conforme descrição das funções 
               constantes do Anexo II deste Edital, considerando os respectivos conteúdos programáticos que fazem 
               parte do Anexo III e Anexo IV, conforme o cargo. 

               18.15 Atividades para os cargos de Motorista I – Veículos Leves, Motorista II – Veículos Leves e Utilitário 
               e Motorista IV – Caminhões: 

               18.15.1 O candidato deve operar o veículo de forma adequada, partindo do local em que se encontra, sem 
               cometer erros ou demonstrar insegurança que ofereça risco para si, para os avaliadores e para o 
               veículo, atendendo as orientações de execução definidas pelo avaliador, de forma adequada, 
               atendendo aos critérios indicados. Ao final da prova, o veículo deverá ser conduzido, se for o caso, ao 
               seu local de origem. 

               18.15.2 O exame de direção veicular será realizado em percurso comum a todos os candidatos, a ser 
               determinado no dia da prova, com duração máxima de até 15 (quinze) minutos, onde será avaliado o 
               comportamento do candidato com relação aos procedimentos a serem observados durante o trajeto, 
               as regras gerais de trânsito e o desempenho na condução do veículo, tais como: rotação do motor, uso 
               do câmbio, freios, localização do veículo na pista, velocidade desenvolvida, obediência à sinalização 
               de trânsito (vertical e horizontal) e semafórica, como também outras situações durante a realização do 
               exame. 

               18.15.3 O candidato partirá de 10 (dez) pontos, sendo que, para cada falta cometida, serão descontados pontos 
               conforme quadro a seguir: 

               CATEGORIA DA FALTA PONTOS A SEREM DESCONTADOS 
               Faltas Graves 1,00 
               Faltas Médias 0,50 
               Faltas Leves 0,25 

               18.15.4 São faltas eliminatórias: 

               a) desobedecer à sinalização semafórica e de parada obrigatória; 
               b) encostar ou avançar sobre o meio-fio; 
               c) não colocar o veículo na área balizada em, no máximo, três tentativas; 
               d) avançar (derrubar ou encostar) sobre o balizamento demarcado; 
               e) transitar em contramão de direção; 
               f) não completar a realização de todas as etapas do exame dentro do tempo limite; 
               g) avançar a via preferencial; 
               h) provocar acidente durante a realização do exame ou avaria no veículo; 
               i) não dar preferência de passagem ao pedestre que estiver atravessando a via transversal para onde 

               se dirige o veículo, ou ainda quando o pedestre não tiver concluído a travessia, mesmo que ocorra 
               sinal verde para o veículo. 

               18.16 Atividades para os cargos de Operador de Máquinas e Equipamentos Pesados, Operador de 
               Patrola, Operador de Retroescavadeira e Operador de Trator Agrícola: 

               18.16.1 A prova constituir-se-á na execução de tarefas a serem realizadas individualmente pelo candidato, 
               previamente elaboradas pela Banca Examinadora, com a avaliação por meio de planilhas, tomando-se 
               por base as atribuições do cargo público, com tempo máximo de 15 (quinze) minutos para a execução 
               da prova. 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 14 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               18.16.2 A avaliação será feita pelo desempenho do candidato no trabalho que executará, dentro das normas 
               técnicas, levando-se em consideração o conhecimento técnico e a habilidade de execução do 
               equipamento. Serão avaliados os seguintes pontos: I – Verificação do equipamento; II – Habilidades 
               ao operar o equipamento; III – Aproveitamento do equipamento; IV – Produtividade; V – 
               Técnica/Aptidão/Eficiência nos Conhecimentos específicos.  

               18.16.3 O candidato partirá de 10 (dez) pontos, sendo que para cada falta cometida serão descontados pontos 
               conforme quadro a seguir: 

               CATEGORIA DA FALTA PONTOS A SEREM DESCONTADOS 
               Faltas Graves 1,00 
               Faltas Médias 0,50 
               Faltas Leves 0,25 

               18.17 A prova poderá ser realizada em mais de um tipo de equipamento, sendo que todos os candidatos 
               deverão ser avaliados em todos os tipos de equipamentos disponibilizados. 

               18.18 Os veículos que serão utilizados na prova prática serão fornecidos pela Prefeitura Municipal, no estado 
               em que se encontrarem. 

               18.19 Caso o candidato demonstre conhecimento insuficiente ou insegurança, oferecendo qualquer tipo de 
               risco na operação, será impedido de realizar a prova e considerado desclassificado e eliminado do 
               Concurso Público. 

               18.20 A FURB e a Prefeitura Municipal de Biguaçu não se responsabilizam por eventuais acidentes que 
               possam vir a acontecer durante a realização da Prova Prática. 

               18.21 A prova será avaliada na escala de 0,00 (zero) a 10,00 (dez), devendo o candidato obter no mínimo 
               5,00 (cinco) para ser considerado como aprovado na Prova Prática. 

               18.22 Ao concluir a sua prova, o candidato deverá retirar-se imediatamente do local de aplicação sem 
               comunicar-se com os demais candidatos. 

               18.23 A prova prática será gravada pela comissão do concurso em áudio e vídeo para fins de registro. 

               18.24 Será eliminado do concurso o candidato que: 

               a) não comparecer, apresentar-se após o horário estabelecido para o início da prova ou que se 
               ausentar do local de espera ou do local de prova sem autorização da Comissão do Concurso Público 
               antes de realizar sua prova, sendo que, em nenhuma hipótese, haverá segunda chamada, seja qual 
               for o motivo alegado; 

               b) tornar-se culpado por incorreção ou descortesia para com quaisquer dos fiscais, executores e seus 
               auxiliares ou autoridades presentes; 

               c) não assinar a Lista de Presença. A negativa em assinar a Lista de Presença ou a ausência de 
               assinatura nos referidos documentos, por qualquer motivo, implicará na eliminação do candidato; 

               d) perturbar de qualquer modo a ordem dos trabalhos durante a preparação ou realização da prova; 
               e) infringir qualquer situação prevista nos itens 15.1 e 15.2 deste edital. 

               18.25 O resultado preliminar da Prova Prática será divulgado no dia 29 de setembro de 2025, no endereço 
               eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025, cabendo 
               recurso, conforme procedimentos e normas previstas no item 21 deste Edital. 

               19 DO RESULTADO PRELIMINAR DO CONCURSO PÚBLICO 

               19.1 O resultado preliminar do Concurso Público será publicado no dia 07 de outubro de 2025, no endereço 
               eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital n.º 001/2025, cabendo 
               recurso, conforme procedimentos e normas previstas no item 21 deste Edital. 

               20 DA CLASSIFICAÇÃO E DO RESULTADO FINAL 

               20.1 A classificação final dos candidatos será expressa na escala de 0,00 (zero) a 10,00 (dez) pontos, com 
               duas casas decimais após a vírgula, conforme quadro a seguir: 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 15 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               CARGO FÓRMULA NOTA FINAL 
               Motorista I – Veículos Leves 
               Motorista II – Veículos Leves e Utilitários 
               Motorista IV – Caminhões 
               Operador de Máquinas e Equipamentos Pesados NF = ((NPO + NPP) / 2) 
               Operador de Patrola 
               Operador de Retroescavadeira 
               Operador de Trator Agrícola 

               Demais cargos NF = NPO 

                
               Legenda: NF = Nota Final 

               NPO = Nota da Prova Objetiva 
               NPP = Nota da Prova Prática 

               20.2 Ocorrendo empate na média final, será aplicado o critério conforme o item 17 deste Edital. 

               20.3 No dia 17 de outubro de 2025, será publicado o resultado final do Concurso Público, por ordem 
               decrescente de nota, contendo o número da classificação, o número da inscrição, o cargo e o nome do 
               candidato, no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital 
               n.º 001/2025. 

               20.4 Serão confeccionadas duas relações de candidatos aprovados: 

               a) a primeira contendo todos os candidatos aprovados no Concurso Público, para convocação de 
               acordo com a ordem decrescente da nota final; 

               b) a segunda contendo somente os candidatos com deficiência, por ordem decrescente da nota final, 
               para efeito do preenchimento das vagas reservadas à PcD.  

               20.5 A partir do dia 24 de outubro de 2025 será publicada a homologação do Concurso Público no Diário 
               Oficial do Município de Biguaçu. 

               21 DOS RECURSOS 

               21.1 Caberão recursos aos seguintes atos do Concurso Público: 

               a) Indeferimento do pedido de Isenção da Taxa da Inscrição; 
               b) Indeferimento do pedido de Vagas Reservadas;  
               c) Indeferimento do pedido de Condições Especiais;  
               d) Indeferimento da Inscrição; 
               e) Gabarito Preliminar/Questões da Prova Objetiva;  
               f) Resultado preliminar da Prova Prática; 
               g) Resultado preliminar do Concurso Público. 

               21.2 Para recorrer, o candidato deverá utilizar unicamente o sistema eletrônico de interposição de recurso, 
               por meio do endereço eletrônico http://concursos.furb.br/, na Área do Candidato, disponível a partir da 
               opção “Recursos”, seguindo as orientações da página, no prazo de 2 (dois) dias corridos, a serem 
               contados do primeiro dia subsequente à publicação do ato em desfavor do qual deseja o candidato 
               recorrer, conforme datas previstas no cronograma deste Edital. 

               21.3 Somente serão apreciados os recursos expressos em termos convenientes e que apontarem as 
               circunstâncias que os justifiquem. Recurso em desacordo com as normas estabelecidas neste Edital, 
               inconsistente ou intempestivo será preliminarmente indeferido. 

               21.4 No período de recurso, não haverá possibilidade de envio de documentação pendente ou 
               complementação de documentos.  

               21.5 As respostas aos recursos, inclusive às solicitações de impugnação deste Edital, serão publicadas 
               coletivamente no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - 
               Edital n.º 001/2025, conforme as datas previstas no cronograma deste Edital. 

               21.6 A decisão final será soberana e definitiva, não existindo, dessa forma, recurso contra resultado de 
               recurso. 

               21.7 Caberá à FURB, mediante recomendação da Banca responsável pela elaboração da prova, anular 
               questões, quando for o caso.  

               21.8 Na hipótese de anulação de questão, esta será considerada como respondida corretamente por todos 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 16 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               os candidatos, independentemente de terem recorrido ou não. 

               21.9 Se da análise do recurso resultar a alteração de resposta de alguma questão da prova, os pontos 
               correspondentes serão atribuídos somente aos candidatos que a responderam corretamente. 

               21.10 A FURB não se responsabilizará por recursos não recebidos por motivos de ordem técnica dos 
               computadores, falhas de comunicação, congestionamento das linhas de comunicação, fraudes virtuais, 
               códigos maliciosos (vírus), bem como outros fatores de ordem técnica que impossibilitem a 
               transferência de dados. 

               22 DA CONVOCAÇÃO, NOMEAÇÃO E POSSE 

               22.1 As providências e atos necessários para a convocação e contratação dos candidatos 
               aprovados/classificados e habilitados são de competência e responsabilidade da Prefeitura Municipal 
               de Biguaçu.  

               22.2 Os candidatos aprovados serão convocados de acordo com a ordem de classificação final, para o 
               preenchimento das vagas existentes, observada a necessidade e a conveniência da Prefeitura 
               Municipal de Biguaçu. 

               22.3 A convocação e a nomeação do candidato aprovado em concurso serão publicadas no Diário Oficial 
               do Município de Biguaçu e no site da Prefeitura Municipal em https://www.bigua.sc.gov.br/. É de 
               responsabilidade do candidato o acompanhamento da publicação do respectivo ato e dos prazos dele 
               decorrentes.  

               22.4 Os candidatos serão convocados por meio de comunicação oficial, via mensagem eletrônica, cabendo-
               lhes o dever de manter os seus dados cadastrais atualizados. 

               22.5 É de exclusiva responsabilidade do candidato manter seus dados pessoais atualizados até a publicação 
               do resultado oficial na sua área do candidato, no endereço eletrônico http://concursos.furb.br. Após a 
               publicação final do certame, eventuais atualizações deverão ser feitas presencialmente no Setor de 
               Recursos Humanos da Prefeitura Municipal de Biguaçu, ou via correspondência com Aviso de 
               Recebimento (AR), indicando o cargo, a colocação e fazendo menção expressa ao presente Edital, 
               para o seguinte endereço: Rua São José, n° 61 - Centro, Biguaçu/SC – A/C Setor de Recursos 
               Humanos. 

               22.6 A Prefeitura Municipal de Biguaçu não se responsabiliza por falhas de comunicação, congestionamento 
               das linhas de comunicação, fraudes virtuais, códigos maliciosos (vírus), bem como outros fatores de 
               ordem técnica que impossibilitem o envio e/ou recebimento de mensagem eletrônica para atualização 
               de dados cadastrais e/ou convocação. 

               22.7 Os prazos para a nomeação e a posse deverão obedecer à legislação vigente do Município. 

               22.8 O candidato que deixar de comparecer no prazo estabelecido perderá automaticamente a vaga, sendo 
               convocado o candidato subsequente. 

               22.9 Na nomeação, o candidato deverá atender às condições a seguir: 

               a) submeter-se à Perícia Médica pela Junta Médica Funcional;  
               b) providenciar, a suas expensas, os exames complementares que se fizerem necessários à realização 

               do Exame Médico Admissional; 
               c) atender aos dispositivos referentes aos requisitos básicos para investidura em Cargo Público.  

               22.9.1 A perícia médica, inclusive para os candidatos com deficiência, será eliminatória, sendo excluídos do 
               Concurso os candidatos que não apresentarem aptidão física e/ou mental para o exercício do serviço 
               público para o qual se inscreveram. 

               22.10 A não comprovação de quaisquer dos pré-requisitos definidos para o cargo, mediante documentação 
               específica, e/ou a apresentação de documentos falsos ou inválidos acarretará a desclassificação e 
               consequente eliminação do candidato do Concurso Público. 

               22.11 Será vedada a posse de servidor público demitido ou destituído de cargo, nas hipóteses previstas no 
               Estatuto dos Servidores Públicos do Município de Biguaçu. 

               22.12 Será vedada a nomeação, posse ou contratação, no âmbito da Administração Pública Municipal, para 
               cargos efetivos, comissionados ou funções públicas, de pessoas condenadas por decisão judicial 
               transitada em julgado ou proferida por órgão colegiado, conforme disposições da Lei Ordinária 
               Municipal n.º 4.371/2025. 

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 17 de 18 



               ESTADO DE SANTA CATARINA 
               PREFEITURA MUNICIPAL DE BIGUAÇU  
               CONCURSO PÚBLICO  
               EDITAL N.º 001/2025 
                

               22.13 Dúvidas referentes à convocação devem ser encaminhadas à Prefeitura Municipal de Biguaçu, 
               exclusivamente por e-mail, para o endereço eletrônico: setorpessoalbigua@bigua.sc.gov.br, 
               devidamente identificado com o nome completo do candidato e a referência ao concurso regido por 
               este Edital. 

               23 DA DELEGAÇÃO DE COMPETÊNCIA DO CONCURSO PÚBLICO 

               23.1 Fica delegada competência à FURB para: 

               a) receber as inscrições; 
               b) deferir e indeferir as inscrições; 
               c) elaborar, aplicar, julgar, corrigir e avaliar as provas; 
               d) receber e apreciar os recursos; 
               e) divulgar os resultados das provas, o resultado e a classificação finais; 
               f) prestar informações sobre o Concurso Público de que trata este Edital. 

               24 DAS DISPOSIÇÕES FINAIS 

               24.1 Para o esclarecimento de dúvidas e informações sobre o Concurso Público, o candidato deverá entrar 
               em contato por meio do WhatsApp (47) 3321-0150 ou pelo e-mail concursopublico@furb.br. O 
               atendimento é realizado de segunda a sexta-feira, conforme calendário institucional, das 8h às 17h. 

               24.2 O ato de inscrição importa no conhecimento das instruções e na aceitação total das condições do 
               Concurso Público fixadas neste Edital. 

               24.3 A inexatidão das afirmativas e/ou irregularidades dos documentos apresentados pelo candidato, 
               verificadas a qualquer tempo, em especial por ocasião da sua admissão, acarretarão a nulidade da 
               inscrição e a desclassificação dele do Concurso Público, sem prejuízo de medidas de ordem 
               administrativa, civil e/ou criminal. 

               24.4 Em situações excepcionais, a qualquer momento, ao se constatarem vícios ou incongruências em 
               qualquer das etapas deste certame, os resultados poderão ser revistos. 

               24.5 Os itens deste Edital poderão sofrer eventuais alterações, atualizações ou acréscimos enquanto não 
               consumada a providência ou evento que lhe disser respeito até a data da convocação dos candidatos 
               para a prova correspondente, circunstância que será mencionada em errata, adendo ou aviso a ser 
               publicado no endereço eletrônico http://concursos.furb.br, em Prefeitura Municipal de Biguaçu - Edital 
               n.º 001/2025. 

               24.6 Os casos omissos neste Edital serão resolvidos pela FURB e pela Prefeitura Municipal de Biguaçu. 

               24.7 Para dirimir eventuais questões oriundas deste Concurso Público que não possam ser resolvidas pela 
               FURB e pela Prefeitura Municipal de Biguaçu, fica eleito o Foro da Comarca de Biguaçu, com a 
               exclusão de qualquer outro, por mais privilegiado que seja. 

               24.8 Integram este Edital os seguintes Anexos: 

               CARGOS, VAGAS, VENCIMENTO, CARGA HORÁRIA SEMANAL (CH) E 
               ANEXO I 

               REQUISITOS 

               ANEXO II ATRIBUIÇÕES DO CARGOS 

               CONTEÚDO PROGRAMÁTICO – NÍVEL FUNDAMENTAL I COMPLETO – SÉRIES 
               ANEXO III 

               INICIAIS 

               ANEXO IV CONTEÚDO PROGRAMÁTICO – NÍVEL FUNDAMENTAL COMPLETO II 

               ANEXO V CONTEÚDO PROGRAMÁTICO – NÍVEL MÉDIO/TÉCNICO 

               ANEXO VI CONTEÚDO PROGRAMÁTICO – NÍVEL SUPERIOR 

                

               Biguaçu, 27 de junho de 2025. 
                

               Salmir da Silva 
               Prefeito Municipal 

                

               FUNDAÇÃO UNIVERSIDADE REGIONAL DE BLUMENAU                      Página 18 de 18
               """;
    }
}