describe('template spec', () => {
    it('Check if login works (invalid login)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
        cy.get('#username').type('test')
        cy.get('#password').type('test')
        cy.contains('Log in').click()
        cy.contains('Login lukte niet')
    })

    // it('Check if login works (valid login)', () => {
    //     cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Login')
    //     cy.get('#username').type('test')
    //     cy.get('#password').type('test')
    //     cy.get('log in').click()
    //     cy.contains('Login lukte niet')
    // })
})