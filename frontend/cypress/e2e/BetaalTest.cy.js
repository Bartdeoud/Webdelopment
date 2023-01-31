describe('Betaal test', () => {
    it('Checks if betalen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ticket')
        cy.contains('Betaling mislukt').should('be.visible')
        cy.url().should('include', '/ticket')
    })

    it('Checks if url is read correctly (succes)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ticket?succes=True')
        cy.contains('Betaling gelukt').should('be.visible')
        cy.url().should('include', '/ticket?succes=True')
    })

    it('Checks if url is read correctly (failed)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ticket?succes=False')
        cy.contains('Betaling mislukt').should('be.visible')
        cy.url().should('include', '/ticket?succes=False')
    })

    it('Checks if betaling works (succes)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Gebruiker')
        cy.get('#password').type('GebruikerW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Programma')
        cy.contains('bestel').click()
        cy.get('#SelectedRang').select('Rang 1')
        cy.get('#NumberTickets').type('1')
        cy.get('.btn').click()
        cy.wait(1000)
        cy.url().should('include', '/Winkelmand')
        cy.contains('1')
        cy.get('input').type('Cypress@Cypress2.com')
        cy.get('.btn').click()

        cy.origin('https://fakepay.azurewebsites.net', () => {
            cy.get('#account').type('NL55ABNA5660751954')
            cy.contains('Betaal').click()	
        })
        
        cy.contains('Betaling gelukt').should('be.visible')
        cy.url().should('include', '/ticket?succes=True')
    })

    it('Checks if betaling works (failed)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Gebruiker')
        cy.get('#password').type('GebruikerW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')

        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Programma')
        cy.contains('bestel').click()
        cy.get('#SelectedRang').select('Rang 1')
        cy.get('#NumberTickets').type('1')
        cy.get('.btn').click()
        cy.wait(1000)
        cy.url().should('include', '/Winkelmand')
        cy.contains('1')
        cy.get('input').type('Cypress@Cypress2.com')
        cy.get('.btn').click()

        cy.origin('https://fakepay.azurewebsites.net', () => {
            cy.get('#account').type('CYPRESSBANKING1234')
            cy.contains('Betaal').click()	
        })

        cy.contains('Betaling mislukt').should('be.visible')
        cy.url().should('include', '/ticket?succes=False')
    })
})