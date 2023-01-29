describe('template spec', () => {
    it('Check if login works (invalid login)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('test')
        cy.get('#password').type('test')
        cy.contains('Log in').click()
        cy.contains('Login lukte niet')
    })

    it('Check if login works (valid login)', () => {
        // Username: CypressTest, Email: CypressTest@Cypress, Password: CypressW1!
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('CypressTest')
        cy.get('#password').type('CypressW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
    })
    
    it('Check if login works (Medewerker)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Medewerker')
        cy.get('#password').type('MedewerkerW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
    })

    it('Check if login works (Admin)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Admin')
        cy.get('#password').type('AdminW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
    })

    it('Check if login works (Artiest)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Artiest')
        cy.get('#password').type('ArtiestW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
    })
    
    it('Check if login works (Donateur)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('Donateur')
        cy.get('#password').type('DonateurW1!')
        cy.contains('Log in').click()
        cy.contains('U bent ingelogd')
    })
})