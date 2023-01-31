describe('Review test', () => {
    it('Checks if the review is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Donateur')
        cy.get('#password').type('DonateurW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/BegunstigersPortaal')
        cy.contains('Begunstigers portaal')
        cy.contains('Klik dan hier om een review te schrijven.').click()
        cy.url().should('include', '/Review')
    })
    
    it('Checks if the review plaatsen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Donateur')
        cy.get('#password').type('DonateurW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/BegunstigersPortaal')
        cy.contains('Begunstigers portaal')
        cy.contains('Klik dan hier om een review te schrijven.').click()
        cy.url().should('include', '/Review')
        cy.get(':nth-child(8) > .evenementblock > #bestel > .btn').click()
        cy.url().should('include', '/ReviewToevoegen')
    })

    it('Checks if the review plaatsen works', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Donateur')
        cy.get('#password').type('DonateurW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/BegunstigersPortaal')
        cy.contains('Begunstigers portaal')
        cy.contains('Klik dan hier om een review te schrijven.').click()
        cy.url().should('include', '/Review')
        cy.get(':nth-child(8) > .evenementblock > #bestel > .btn').click()
        cy.url().should('include', '/ReviewToevoegen')

        cy.get('#Review').type('Cypress test deze review komt echt 1000 keer in de database')
        cy.get('.btn').click()
        cy.url().should('include', '/Review')
    })
})